const express = require('express');
const mysql = require('mysql');
const bodyParser = require('body-parser');
const cors = require('cors');

const app = express();
const port = 5160;

app.use(cors());
app.use(bodyParser.json());

// Create MySQL connection
const db = mysql.createConnection({
    host: 'localhost',
    user: 'root', // Replace with your MySQL username
    password: '', // Replace with your MySQL password
    database: 'my_app'
});

db.connect((err) => {
    if (err) {
        throw err;
    }
    console.log('MySQL connected...');
});

// Login endpoint
app.post('/login', (req, res) => {
    const { email, password } = req.body;
    const sql = 'SELECT * FROM users WHERE email = ? AND password = ?';
    db.query(sql, [email, password], (err, result) => {
        if (err) {
            res.status(500).send({ error: err.message });
        } else if (result.length > 0) {
            res.send({ message: 'Login successful', user: result[0] });
        } else {
            res.status(401).send({ message: 'Invalid credentials' });
        }
    });
});

// Signup endpoint
app.post('/signup', (req, res) => {
    const { name, email, password } = req.body;
    const sql = 'INSERT INTO users (name, email, password) VALUES (?, ?, ?)';
    db.query(sql, [name, email, password], (err, result) => {
        if (err) {
            res.status(500).send({ error: err.message });
        } else {
            res.send({ message: 'User created successfully' });
        }
    });
});

// Save order endpoint
app.post('/save-order', (req, res) => {
    const { firstName, lastName, email, street, address, phone, subtotal, deliveryFee, total, items } = req.body;

    // Start a transaction
    db.beginTransaction((err) => {
        if (err) {
            return res.status(500).send({ error: err.message });
        }

        // Step 1: Save the order
        const orderSql = `
            INSERT INTO orders (first_name, last_name, email, street, address, phone, subtotal, delivery_fee, total)
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)
        `;
        db.query(orderSql, [firstName, lastName, email, street, address, phone, subtotal, deliveryFee, total], (err, result) => {
            if (err) {
                return db.rollback(() => {
                    res.status(500).send({ error: err.message });
                });
            }

            const orderId = result.insertId;

            // Step 2: Save the order items
            const itemSql = `
                INSERT INTO order_items (order_id, item_title, quantity, price)
                VALUES ?
            `;
            const itemValues = items.map(item => [orderId, item.title, item.quantity, item.price]);
            db.query(itemSql, [itemValues], (err, result) => {
                if (err) {
                    return db.rollback(() => {
                        res.status(500).send({ error: err.message });
                    });
                }

                // Commit the transaction
                db.commit((err) => {
                    if (err) {
                        return db.rollback(() => {
                            res.status(500).send({ error: err.message });
                        });
                    }

                    res.send({ message: 'Order saved successfully', orderId });
                });
            });
        });
    });
});


app.listen(port, () => {
    console.log(`Server running on port ${port}`);
});