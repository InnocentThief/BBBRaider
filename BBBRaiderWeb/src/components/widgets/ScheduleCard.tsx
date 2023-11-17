import { Card, ControlGroup, H3, Icon } from "@blueprintjs/core";
import { ScheduleDto } from "../../models/ScheduleDto";
import styled from "styled-components";
import { useNavigate } from "react-router-dom";
import { SCHEDULES_ROUTE } from "../../App";

interface Props {
    item: ScheduleDto
}

const ScheduleCard = ({ item }: Props) => {
    const navigate = useNavigate();

    return (
        <SchedCard interactive={true} onClick={() => { navigate(`${SCHEDULES_ROUTE}/${item.scheduleKey}`) }}>
            <H3>
                {item.raid?.name}
            </H3>
            <SchedInfoGroup>
                <Icon icon='calendar' />
                <SchedInfoValue>{item.date}</SchedInfoValue>
            </SchedInfoGroup>
            <SchedInfoGroup>
                <Icon icon='crown' />
                <SchedInfoValue>{item.raidLeader?.name}</SchedInfoValue>
            </SchedInfoGroup>
            <SchedInfoGroup>
                <Icon icon='people' />
                <SchedInfoValue>{item.playerCount}</SchedInfoValue>
            </SchedInfoGroup>
        </SchedCard>
    )
}

const SchedCard = styled(Card)`
  background: #f6f7f9;
  .bp5-dark & {
    background: rgba(0,0,0,0.4);
  }
`

const SchedInfoGroup = styled(ControlGroup)`
    display: flex;
    margin-top: 6px;
`

const SchedInfoValue = styled.div`
`

export default ScheduleCard