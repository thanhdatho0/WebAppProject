import Header from "./Header"
import "./App.css"
import { library } from '@fortawesome/fontawesome-svg-core'
import {faCartShopping, fas } from '@fortawesome/free-solid-svg-icons'


library.add(fas, faCartShopping)

const App = () => {
  return (
    <>
      <Header/>
    </>
  )
}

export default App