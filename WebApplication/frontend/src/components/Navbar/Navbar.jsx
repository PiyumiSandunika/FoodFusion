import React, {useState} from 'react'
import './Navbar.css'
import { assets } from '../../assets/assets'

const Navbar = () => {

    const [menu,setMenu] = useState("home");

  return(
    <div className='navbar'>
        <img src={assets.logo} alt="" className="logo-icon"/>
        <img src={assets.res_name} alt="" className="logo"/>
        <ul className="navbar-menu">
          <li onClick={()=>setMenu("home")} className={menu==="home"?"active":""}>home</li>
          <li onClick={()=>setMenu("about")} className={menu==="about"?"active":""}>about</li>
          <li onClick={()=>setMenu("menu")} className={menu==="menu"?"active":""}>menu</li>
          <li onClick={()=>setMenu("contact-us")} className={menu==="contact-us"?"active":""}>contact us</li>
        </ul>
        <div className="navbar-right">
          <img src={assets.search_icon} alt="" className="search-icon" />
          <div className="navbar-search-icon">
          <img src={assets.basket_icon} alt="" className="basket-icon" />
          <div className="dot"></div>
          </div>
          <button>sign in</button>
        </div>


    </div>
  )
}

export default Navbar
