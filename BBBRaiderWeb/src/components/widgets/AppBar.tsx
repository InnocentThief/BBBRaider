import { Alignment, Button, Classes, Navbar } from '@blueprintjs/core'
import React from 'react'
import { Link } from 'react-router-dom'
import styled from 'styled-components'
import { SCHEDULES_ROUTE } from '../../App'
// import styled from 'styled-components'

class AppBar extends React.Component {
    render() {
        return (
            <>
                <BBBNavbar fixedToTop={true} >
                    <Navbar.Group align={Alignment.LEFT}>
                        <img src='/BBB.png' height={50} width={50} />
                        <Navbar.Heading>
                            <Link to='/'>
                                <Button
                                    className={Classes.MINIMAL}
                                    text='BBB Raiders'
                                    title=''
                                />
                            </Link>
                        </Navbar.Heading>
                        <Navbar.Divider />
                        <Link to={SCHEDULES_ROUTE}>
                            <Button
                                className={Classes.MINIMAL}
                                icon='timeline-events'
                                text='Raidplaner'
                                title='Raidplaner'
                            />
                        </Link>
                        {/* <Link to='/AdvancedRaids'>
                            <Button
                                className={Classes.MINIMAL}
                                icon='build'
                                text='Advanced Raids'
                                title='Advanced Raids Planer'
                            />
                        </Link> */}
                    </Navbar.Group>
                </BBBNavbar>
                <TopMargin />
            </>
        )
    }
}

const TopMargin = styled.div`
    position: fixed;
    width: 100%;
    height: 14px;
    background: rgba(0,0,0,0.5);
    .bp5-dark & {
        background: rgba(0,0,0,0);
    }
`

const BBBNavbar = styled(Navbar)`
    background: rgba(0,0,0,0);
    .bp5-dark & {
        background: rgba(0,0,0,0.5);
    }
`

export default AppBar
