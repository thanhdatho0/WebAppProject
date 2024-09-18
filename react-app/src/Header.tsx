import appLogo from "./assets/icon.svg";
import cartIcon from "./assets/cart.svg";
import searchIcon from "./assets/search.svg";
import Navigations from "./Navigations";

const Header = () => {

  return (
    <header className="header fixed-top w-100 bg-white border-bottom border-yd-line-divider z-30">
      <div className="header-container h-100 mx-auto d-flex justify-content-between align-items-center">
        <div className="d-flex align-items-center gap-5">
          <span className="cursor-pointer">
            <img src={appLogo} alt="" width='88'/>
          </span>
            <Navigations/>
        </div>
        <div className="d-flex align-items-center gap-4">
        <span className="cursor-pointer">
            <img src={searchIcon} alt="" width={20} height={20}/>
          </span>
          <a href="#">
            <div className="position-relative">
              <img src={cartIcon} alt="" width='24px' height='24px' />
            </div>
          </a>
        </div>
      </div>
    </header>
  )
}

export default Header