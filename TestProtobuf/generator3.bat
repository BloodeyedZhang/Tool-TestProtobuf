call python xls_deploy_tool.py CRAZY_INFO xls/crazy_info.xls
call protoc tnt_deploy_crazy_info.proto --descriptor_set_out=crazy_info.protodesc
call ProtoGen\protogen -i:crazy_info.protodesc -o:crazy_info.cs
pause