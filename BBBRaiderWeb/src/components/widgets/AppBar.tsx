import { Alignment, Navbar } from '@blueprintjs/core'
import React from 'react'

class AppBar extends React.Component {
  render() {
    return (
      <Navbar fixedToTop={true}>
        <Navbar.Group align={Alignment.LEFT}>Navbar</Navbar.Group>
      </Navbar>
    )
  }
}

export default AppBar
