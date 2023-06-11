import { GetActiveClaimData } from "../../liveData/GetActiveClaimData";
import { Loading } from "../customization/Spinner";

export function CurrentPhasePrice() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const mintPriceValue = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.price.toBigInt()
  );

  const stringPrice = mintPriceValue.toString();

  const mintPriceSymbol = isLoading
    ? isLoading
    : error != null
    ? error.toString()
    : allClaimData.currencyMetadata.symbol;

  const maxClaimPerWallet = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.maxClaimablePerWallet
  );

  const price = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : stringPrice.length > 1 ? (
    stringPrice[0] +
    '.' +
    stringPrice[1] +
    '' +
    stringPrice[2] +
   ' ' +
    mintPriceSymbol
  ) : (
    'FREE'
  );

  return (
    <>
      <label>
        Max Claim Per Wallet:{' '}
        <b className="data-style count-color">{maxClaimPerWallet}</b>
      </label>
      <br />
      <label>
        Mint Price: <b className="data-style count-color">{price}</b>
      </label>
    </>
  );
}
