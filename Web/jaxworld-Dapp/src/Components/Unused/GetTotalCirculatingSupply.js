import { useTotalCirculatingSupply } from "@thirdweb-dev/react";
import { ContractAddress } from "../Helpers/utils/GetContract";
// Your smart contract address


export function GetTotalCirculatingSupply() {

    const { contract } = ContractAddress();
    const { data:totalSupplyData, isLoading, error } = useTotalCirculatingSupply(contract);

      return {
          totalSupplyData,
          isLoading,
          error    
    };
}