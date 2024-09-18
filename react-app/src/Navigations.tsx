import data from "./api/collection.json"

const Navigations = () => {

  return (
    <>
        <ul className="collection-list d-inline-flex" style={{marginBottom: '0'}}>
            {data.map((collectionItem) => 
              (<li key={collectionItem.title} className="list-items">
                  <a href={collectionItem.href} className="d-inline-block position-relative px-3 py-2">{collectionItem.title}</a>
              </li>))}
        </ul>
    </>
  )
}

export default Navigations