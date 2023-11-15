// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
import './App.css'
// import { AppShell, Burger, Title } from '@mantine/core'
import styled from 'styled-components'
import AppBar from './components/widgets/AppBar'

function App() {
  // const [count, setCount] = useState(0)

  return (
    <>
      <AppBar />
    </>
    // <AppShell
    //   padding="md"
    //   header={{ height: 60 }}
    //   navbar={{
    //     width: 250,
    //     breakpoint: 'x1',
    //     collapsed: { mobile: true },
    //   }}
    // >
    //   <AppShell.Header>Header</AppShell.Header>
    //   <AppShell.Main>
    //     Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo
    //     Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo Hallo
    //   </AppShell.Main>
    // </AppShell>
    // <>
    //   <div>
    //     <a href="https://vitejs.dev" target="_blank">
    //       <img src={viteLogo} className="logo" alt="Vite logo" />
    //     </a>
    //     <a href="https://react.dev" target="_blank">
    //       <img src={reactLogo} className="logo react" alt="React logo" />
    //     </a>
    //   </div>
    //   <h1>Vite + React</h1>
    //   <div className="card">
    //     <button onClick={() => setCount((count) => count + 1)}>
    //       count is {count}
    //     </button>
    //     <p>
    //       Edit <code>src/App.tsx</code> and save to test HMR
    //     </p>
    //   </div>
    //   <p className="read-the-docs">
    //     Click on the Vite and React logos to learn more
    //   </p>
    // </>
  )
}

export default App

const Content = styled.div`
  display: flex;
  align-items: center;
  justify-content: space-between;
  height: 100%;
`
