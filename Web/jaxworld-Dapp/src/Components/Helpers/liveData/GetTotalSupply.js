import { useEffect, useState } from "react";
import { GetContract } from "../utils/GetContract";
// Your smart contract address

export function GetTotalSupply() {
  const { contract, isLoading } = GetContract();

  const initialSupply = 0;

  const [supply, setTotalSupply] = useState(initialSupply);

  useEffect(() => {
    (async () => {
      setTotalSupply((isLoading ? 1 : ((await contract.erc721.totalCount()).toNumber(Int32Array))));
    })();
  });


  return {
    supply,
  };
}
