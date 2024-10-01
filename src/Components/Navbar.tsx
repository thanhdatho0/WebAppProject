import Logo from "./Logo"
import logo_img from "../assets/logo.svg"
import Navigation from "./Navigation"
import navigateData from "../JsonData/Navigation.json"
import Search from "./Search"
import Cart from "./Cart"

const Navbar = () => {
  return (
    <nav id="head-navbar" className="flex flex-row justify-around items-center shadow-sm w-full">
        <div className="left-side flex gap-8 items-center p-3 ">
            <Logo logo_src={logo_img}/>
            <Navigation items={navigateData}/>
        </div>
        <div className="righ-side flex flex-row items-center gap-8 p-3 text-center">
            <Search/>
            <Cart/>
        </div>
    </nav>
  )
}

export default Navbar