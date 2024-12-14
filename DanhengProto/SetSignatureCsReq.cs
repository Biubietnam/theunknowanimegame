using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200112F RID: 4399
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetSignatureCsReq : IMessage<SetSignatureCsReq>, IMessage, IEquatable<SetSignatureCsReq>, IDeepCloneable<SetSignatureCsReq>, IBufferMessage
	{
		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600C42D RID: 50221 RVA: 0x0020EAA8 File Offset: 0x0020CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetSignatureCsReq> Parser
		{
			get
			{
				return SetSignatureCsReq._parser;
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600C42E RID: 50222 RVA: 0x0020EAAF File Offset: 0x0020CCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetSignatureCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600C42F RID: 50223 RVA: 0x0020EAC1 File Offset: 0x0020CCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetSignatureCsReq.Descriptor;
			}
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x0020EAC8 File Offset: 0x0020CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureCsReq()
		{
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x0020EADB File Offset: 0x0020CCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureCsReq(SetSignatureCsReq other) : this()
		{
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x0020EB00 File Offset: 0x0020CD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureCsReq Clone()
		{
			return new SetSignatureCsReq(this);
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600C433 RID: 50227 RVA: 0x0020EB08 File Offset: 0x0020CD08
		// (set) Token: 0x0600C434 RID: 50228 RVA: 0x0020EB10 File Offset: 0x0020CD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x0020EB23 File Offset: 0x0020CD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetSignatureCsReq);
		}

		// Token: 0x0600C436 RID: 50230 RVA: 0x0020EB31 File Offset: 0x0020CD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetSignatureCsReq other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x0020EB64 File Offset: 0x0020CD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C438 RID: 50232 RVA: 0x0020EBA5 File Offset: 0x0020CDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x0020EBAD File Offset: 0x0020CDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x0020EBB6 File Offset: 0x0020CDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x0020EBF0 File Offset: 0x0020CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x0020EC33 File Offset: 0x0020CE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetSignatureCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x0020EC69 File Offset: 0x0020CE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x0020EC74 File Offset: 0x0020CE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x04004F4C RID: 20300
		private static readonly MessageParser<SetSignatureCsReq> _parser = new MessageParser<SetSignatureCsReq>(() => new SetSignatureCsReq());

		// Token: 0x04004F4D RID: 20301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F4E RID: 20302
		public const int SignatureFieldNumber = 5;

		// Token: 0x04004F4F RID: 20303
		private string signature_ = "";
	}
}
