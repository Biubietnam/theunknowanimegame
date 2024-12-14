using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A5 RID: 1701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFightFestDataCsReq : IMessage<GetFightFestDataCsReq>, IMessage, IEquatable<GetFightFestDataCsReq>, IDeepCloneable<GetFightFestDataCsReq>, IBufferMessage
	{
		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x000CEAC7 File Offset: 0x000CCCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFightFestDataCsReq> Parser
		{
			get
			{
				return GetFightFestDataCsReq._parser;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x000CEACE File Offset: 0x000CCCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFightFestDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x000CEAE0 File Offset: 0x000CCCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFightFestDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x000CEAE7 File Offset: 0x000CCCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataCsReq()
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x000CEAEF File Offset: 0x000CCCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataCsReq(GetFightFestDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x000CEB08 File Offset: 0x000CCD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataCsReq Clone()
		{
			return new GetFightFestDataCsReq(this);
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x000CEB10 File Offset: 0x000CCD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFightFestDataCsReq);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x000CEB1E File Offset: 0x000CCD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFightFestDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x000CEB3C File Offset: 0x000CCD3C
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

		// Token: 0x06004C2E RID: 19502 RVA: 0x000CEB62 File Offset: 0x000CCD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x000CEB6A File Offset: 0x000CCD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x000CEB73 File Offset: 0x000CCD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x000CEB8C File Offset: 0x000CCD8C
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

		// Token: 0x06004C32 RID: 19506 RVA: 0x000CEBB2 File Offset: 0x000CCDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFightFestDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x000CEBCF File Offset: 0x000CCDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x000CEBD8 File Offset: 0x000CCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E25 RID: 7717
		private static readonly MessageParser<GetFightFestDataCsReq> _parser = new MessageParser<GetFightFestDataCsReq>(() => new GetFightFestDataCsReq());

		// Token: 0x04001E26 RID: 7718
		private UnknownFieldSet _unknownFields;
	}
}
