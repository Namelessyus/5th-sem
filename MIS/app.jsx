import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import { Button } from './component button/Button'
import { Test } from './page/test'


function App() {
  const [count, setCount] = useState(0)
  
  return (
    <>
      {/* 
      text dynamic
      <Button title={"hi"}/> 
      <Button title={"hello"}/>
      <Button title={"this"}/> 
      <Button title={"that"}/> */}

{/* dynamic text with onClick */}
      <Button onClick={()=>console.log("Button one")} title={"hi"}/> 
      <Button onClick={()=>console.log("Button two")} title={"hello"}/>
      <Button onClick={()=>console.log("Button three")}  title={"this"}/> 
      <Button onClick={()=>console.log("Button four")} title={"that"}/>
      <Test/>
        


    </>
  )
}

export default App

