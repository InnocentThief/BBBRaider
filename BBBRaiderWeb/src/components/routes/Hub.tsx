import { observer } from "mobx-react";
import React from "react";
import styled from "styled-components";
import Vertical from "../layouts/Vertical";

class Hub extends React.Component {

    render() {
        return (
            <Container>
                Hub
            </Container>
        )
    }
}

const Container = styled(Vertical)`
    max-width: 1300px;
    margin: 15px;
    width: 100%;
`

export default observer(Hub)