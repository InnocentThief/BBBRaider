import { observer } from "mobx-react"
import React from "react"
import styled from "styled-components"
import Vertical from "../layouts/Vertical"
import { Context } from "../../contexts"
import ScheduleCard from "../widgets/ScheduleCard"

class Raids extends React.Component {
    async componentDidMount(): Promise<void> {
        const {
            schedule: { loadedSchedules, fetchSchedules }
        } = Context

        if (loadedSchedules.length === 0) {
            await fetchSchedules()
        }
    }

    render() {
        const {
            schedule: { loadedSchedules, loadingSchedules }
        } = Context

        return (
            <Container>
                {loadingSchedules ? (
                    <></>
                ) : (
                    loadedSchedules.length === 0 && (
                        <></>
                    )
                )}
                {loadedSchedules.length > 0 && loadingSchedules === false && (
                    <ScheduleList>
                        {loadedSchedules &&
                            loadedSchedules.map(schedule => (
                                <ScheduleCard key={schedule.scheduleKey} item={schedule} />
                            ))}
                    </ScheduleList>
                )}
            </Container>
        )
    }
}

const Container = styled(Vertical)`
    max-width: 1300px;
    margin: 15px;
    width: 100%;
`

const ScheduleList = styled.div`
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(450px, 1fr));
  gap: 6px;
  width: 100%;
`

export default observer(Raids)