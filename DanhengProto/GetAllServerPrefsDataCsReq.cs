using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000613 RID: 1555
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllServerPrefsDataCsReq : IMessage<GetAllServerPrefsDataCsReq>, IMessage, IEquatable<GetAllServerPrefsDataCsReq>, IDeepCloneable<GetAllServerPrefsDataCsReq>, IBufferMessage
	{
		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x000BF2CF File Offset: 0x000BD4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllServerPrefsDataCsReq> Parser
		{
			get
			{
				return GetAllServerPrefsDataCsReq._parser;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x000BF2D6 File Offset: 0x000BD4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllServerPrefsDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x000BF2E8 File Offset: 0x000BD4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllServerPrefsDataCsReq.Descriptor;
			}
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x000BF2EF File Offset: 0x000BD4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataCsReq()
		{
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x000BF2F7 File Offset: 0x000BD4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataCsReq(GetAllServerPrefsDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x000BF310 File Offset: 0x000BD510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataCsReq Clone()
		{
			return new GetAllServerPrefsDataCsReq(this);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x000BF318 File Offset: 0x000BD518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllServerPrefsDataCsReq);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x000BF326 File Offset: 0x000BD526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllServerPrefsDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x000BF344 File Offset: 0x000BD544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x000BF36A File Offset: 0x000BD56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x000BF372 File Offset: 0x000BD572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x000BF37B File Offset: 0x000BD57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x000BF394 File Offset: 0x000BD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x000BF3BA File Offset: 0x000BD5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllServerPrefsDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x000BF3D7 File Offset: 0x000BD5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x000BF3E0 File Offset: 0x000BD5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BEA RID: 7146
		private static readonly MessageParser<GetAllServerPrefsDataCsReq> _parser = new MessageParser<GetAllServerPrefsDataCsReq>(() => new GetAllServerPrefsDataCsReq());

		// Token: 0x04001BEB RID: 7147
		private UnknownFieldSet _unknownFields;
	}
}
