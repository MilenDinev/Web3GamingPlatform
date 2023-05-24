import { GetUnclaimedSupply } from '../../liveData/GetUnclaimedSupply';
import './../../../../App.css';

export function UnclaimedNFTSupply() {
  const { supply } = GetUnclaimedSupply();

  const unclaimedSupply = supply === 0 ? 'Loading...' : supply;

  return (
    <>
      <h5 className="Fonts">
        Unclaimed Supply: <b>{unclaimedSupply}</b>
        <hr className="my-2" />
      </h5>
    </>
  );
}
