using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200062F RID: 1583
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBasicInfoCsReq : IMessage<GetBasicInfoCsReq>, IMessage, IEquatable<GetBasicInfoCsReq>, IDeepCloneable<GetBasicInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x000C2B32 File Offset: 0x000C0D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBasicInfoCsReq> Parser
		{
			get
			{
				return GetBasicInfoCsReq._parser;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x000C2B39 File Offset: 0x000C0D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBasicInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x000C2B4B File Offset: 0x000C0D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBasicInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x000C2B52 File Offset: 0x000C0D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoCsReq()
		{
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x000C2B5A File Offset: 0x000C0D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoCsReq(GetBasicInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x000C2B73 File Offset: 0x000C0D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBasicInfoCsReq Clone()
		{
			return new GetBasicInfoCsReq(this);
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x000C2B7B File Offset: 0x000C0D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBasicInfoCsReq);
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x000C2B89 File Offset: 0x000C0D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBasicInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x000C2BA8 File Offset: 0x000C0DA8
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

		// Token: 0x06004710 RID: 18192 RVA: 0x000C2BCE File Offset: 0x000C0DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000C2BD6 File Offset: 0x000C0DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000C2BDF File Offset: 0x000C0DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x000C2BF8 File Offset: 0x000C0DF8
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

		// Token: 0x06004714 RID: 18196 RVA: 0x000C2C1E File Offset: 0x000C0E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBasicInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x000C2C3B File Offset: 0x000C0E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x000C2C44 File Offset: 0x000C0E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C78 RID: 7288
		private static readonly MessageParser<GetBasicInfoCsReq> _parser = new MessageParser<GetBasicInfoCsReq>(() => new GetBasicInfoCsReq());

		// Token: 0x04001C79 RID: 7289
		private UnknownFieldSet _unknownFields;
	}
}
