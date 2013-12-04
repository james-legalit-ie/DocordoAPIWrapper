namespace DocordoAPI
{
    public interface IDocordoService
    {
        DocordoAPI.Model.Domain.DocordoCheckInNodeResponse CheckInNode(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.DocordoCheckInNodeBean docordoCheckInNodeBean);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateAdHocDocument<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.Create.DocordoCreateRecordBean createAdHocDocumentBean, T adHocDocumentData);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateAdHocDocumentAndUpload<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.Create.DocordoCreateAdHocDocumentAndUploadBean createAdHocDocumentAndUploadBean, T adHocDocumentData);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateEntity<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.Create.DocordoCreateRecordBean createClientBean, T docordoEntityData);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateFolder<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.Create.DocordoCreateRecordBean createFolderBean, T docordoFolderData);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateMatter<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.Create.DocordoCreateRecordBean createMatterBean, T docordoMatterData);
        DocordoAPI.Model.Domain.DocordoNodeCreateResponse CreateNode<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Domain.DocordoBaseNode<T> docordoNode);
        DocordoAPI.Model.Domain.DocordoNodeDeleteResponse DeleteNode(string docordoDomain, string sessionKey, string cookieJSESSIONID, params string[] nodeIds);
        System.IO.Stream DownloadContentByNodeId(string docordoDomain, string sessionKey, string cookieJSESSIONID, string nodeId);
        DocordoAPI.Model.Domain.DocordoAttributesResponse LoadAttributesByNodeType(string docordoDomain, string sessionKey, string cookieJSESSIONID, string nodeTypeId);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadContentByContainerRecordNumber(string docordoDomain, string sessionKey, string cookieJSESSIONID, string docordoRecordNumber);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByContainerId(string docordoDomain, string sessionKey, string cookieJSESSIONID, string containerId);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByExternalId(string docordoDomain, string sessionKey, string cookieJSESSIONID, string externalId);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByPropertyValue(string docordoDomain, string sessionKey, string cookieJSESSIONID, int property, string value);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByPropertyValue(string docordoDomain, string sessionKey, string cookieJSESSIONID, string property, string value);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByPropertyValue<T>(string docordoDomain, string sessionKey, string cookieJSESSIONID, T property, string value);
        DocordoAPI.Model.Domain.DocordoSearchResponse LoadNodesByRecordNumber(string docordoDomain, string sessionKey, string cookieJSESSIONID, string docordoRecordNumber);
        DocordoAPI.Model.Domain.DocordoNodeTypeDetailResponse LoadNodeTypeDetail(string docordoDomain, string sessionKey, string cookieJSESSIONID, string nodeTypeId);
        DocordoAPI.Model.Domain.DocordoNodeTypeListResponse LoadNodeTypes(string docordoDomain, string sessionKey, string cookieJSESSIONID);
        DocordoAPI.Model.Domain.DocordoLoginResponse Login(string docordoDomain, string username, string password);
        DocordoAPI.Model.Domain.DocordoLogoutResponse Logout(string docordoDomain, string sessionKey, string cookieJSESSIONID);
        DocordoAPI.Model.Domain.DocordoSearchResponse UploadContent(string docordoDomain, string sessionKey, string cookieJSESSIONID, DocordoAPI.Model.Bean.DocordoUploadContentBean uploadContentBean);
    }
}
