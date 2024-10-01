import SearchIcon from "./SearchIcon"

type Props = {}

const Search = (props: Props) => {
  return (
      <div className="relative border-2 border-solid rounded-lg">
        <div className="absolute top-0 bottom-0 left-0">
          <SearchIcon/>
        </div>
        <input type="text" placeholder="Tìm kiếm" className="pl-6 border-none outline-none rounded-lg w-full text-base"/>
      </div>
  )
}

export default Search