import { observer } from "mobx-react";
import React from "react";
import Vertical from "../layouts/Vertical";
import styled from "styled-components";

class AdvancedRaids extends React.Component {

    render() {
        return (
            <Container>Advanced Raids</Container>
        )
    }
}

const Container = styled(Vertical)`
    max-width: 1300px;
    margin: 15px;
    width: 100%;
`

export default observer(AdvancedRaids)