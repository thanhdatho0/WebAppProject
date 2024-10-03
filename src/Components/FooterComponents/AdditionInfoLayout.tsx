import React from 'react'
import info from "./FooterAdditonInfoDatas.json"
import AdditionInfo from './AdditionInfo'


const AdditionInfoLayout = () => {
  return (
    <div className='grid grid-cols-3 gap-2'>
      <div className='row-span-2'>
        <AdditionInfo title={info[0].title} navigateItems={info[0].navigateItems}/>
      </div>
      <div className='row-span-1'>
        <AdditionInfo title={info[1].title} navigateItems={info[1].navigateItems}/>
        <AdditionInfo title={info[2].title} navigateItems={info[2].navigateItems}/>
      </div>
      <div className="row-span-2">
        <AdditionInfo title={info[3].title} navigateItems={info[3].navigateItems}/>
      </div>
    </div>
  )
}

export default AdditionInfoLayout