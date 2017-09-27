call python xls_deploy_tool.py GOODS_INFO xls/crazy_info.xls
call protoc tnt_deploy_goods_info.proto --descriptor_set_out=goods_info.protodesc
call ProtoGen\protogen -i:goods_info.protodesc -o:goods_info.cs

call python xls_deploy_tool.py CRAZY_INFO xls/crazy_info.xls
call protoc tnt_deploy_crazy_info.proto --descriptor_set_out=crazy_info.protodesc
call ProtoGen\protogen -i:crazy_info.protodesc -o:crazy_info.cs
pause