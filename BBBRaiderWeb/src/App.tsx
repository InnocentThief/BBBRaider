// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
import './App.css'
// import { AppShell, Burger, Title } from '@mantine/core'
import styled from 'styled-components'
import AppBar from './components/widgets/AppBar'
import React from 'react'
import { Route, Routes } from 'react-router-dom'
import { observer } from 'mobx-react'
import { Classes } from '@blueprintjs/core'
import Raids from './components/routes/Raids'
import Raid from './components/routes/Raid'
import Hub from './components/routes/Hub'
import AdvancedRaids from './components/routes/AdvancedRaids'

export const SILENTRAID_ROUTE = '/SilentRaids'
export const ADVANCEDRAID_ROUTE = '/AdvancedRaids'

class App extends React.Component {
  render() {

    return (
      <Container className={Classes.DARK}>
        <AppBar />
        <Content>
          <Main>
            <Routes>
              <Route path='/' element={<Hub />} />
              <Route path={SILENTRAID_ROUTE} element={<Raids />} />
              <Route path={`${SILENTRAID_ROUTE}/:scheduleKey`} element={<Raid />} />
              <Route path={ADVANCEDRAID_ROUTE} element={<AdvancedRaids />} />
            </Routes>
          </Main>
        </Content>
      </Container>
    )
  }
}

const Container = styled.div`
  height: 100% !important;
`

const Content = styled.div`
  min-height: 100%;
  padding-top: 60px;
  background: #f6f7f9;
  .bp5-dark & {
    background: rgba(0,0,0,0);
  }
`

const Main = styled.main`
  display: flex;
  justify-content: center;
`

export default observer(App)