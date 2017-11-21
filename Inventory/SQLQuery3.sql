select item.it_code,item.it_name,isnull(s.saled,0)as saled from item left outer join (select sd_item_code,sum(isnull(sd_quantity,0))as saled from sale_detail group by sd_item_code )as s on item.it_code=s.sd_item_code order by s.saled desc


select item.it_code,isnull(purchase_stock.p_stock,0)as p_stock,isnull(sale_stock.s_stock,0)as s_stock,(isnull(purchase_stock.p_stock,0)-isnull(sale_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0)) as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sum(isnull(sd_quantity,0)) as s_stock,sd_item_code from sale_detail group by sd_item_code) as sale_stock on item.it_code=sale_stock.sd_item_code 
