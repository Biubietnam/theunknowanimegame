using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E7 RID: 5095
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdatePlayerSettingCsReq : IMessage<UpdatePlayerSettingCsReq>, IMessage, IEquatable<UpdatePlayerSettingCsReq>, IDeepCloneable<UpdatePlayerSettingCsReq>, IBufferMessage
	{
		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0600E328 RID: 58152 RVA: 0x0025C3BD File Offset: 0x0025A5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdatePlayerSettingCsReq> Parser
		{
			get
			{
				return UpdatePlayerSettingCsReq._parser;
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0600E329 RID: 58153 RVA: 0x0025C3C4 File Offset: 0x0025A5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdatePlayerSettingCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0600E32A RID: 58154 RVA: 0x0025C3D6 File Offset: 0x0025A5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerSettingCsReq.Descriptor;
			}
		}

		// Token: 0x0600E32B RID: 58155 RVA: 0x0025C3DD File Offset: 0x0025A5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingCsReq()
		{
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x0025C3E5 File Offset: 0x0025A5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingCsReq(UpdatePlayerSettingCsReq other) : this()
		{
			this.bEMBICIIHNK_ = ((other.bEMBICIIHNK_ != null) ? other.bEMBICIIHNK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x0025C41A File Offset: 0x0025A61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingCsReq Clone()
		{
			return new UpdatePlayerSettingCsReq(this);
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x0025C422 File Offset: 0x0025A622
		// (set) Token: 0x0600E32F RID: 58159 RVA: 0x0025C42A File Offset: 0x0025A62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBONHLAFBFD BEMBICIIHNK
		{
			get
			{
				return this.bEMBICIIHNK_;
			}
			set
			{
				this.bEMBICIIHNK_ = value;
			}
		}

		// Token: 0x0600E330 RID: 58160 RVA: 0x0025C433 File Offset: 0x0025A633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerSettingCsReq);
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x0025C441 File Offset: 0x0025A641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerSettingCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.BEMBICIIHNK, other.BEMBICIIHNK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E332 RID: 58162 RVA: 0x0025C474 File Offset: 0x0025A674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEMBICIIHNK_ != null)
			{
				num ^= this.BEMBICIIHNK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E333 RID: 58163 RVA: 0x0025C4B0 File Offset: 0x0025A6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E334 RID: 58164 RVA: 0x0025C4B8 File Offset: 0x0025A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x0025C4C1 File Offset: 0x0025A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bEMBICIIHNK_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BEMBICIIHNK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x0025C4F4 File Offset: 0x0025A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEMBICIIHNK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEMBICIIHNK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E337 RID: 58167 RVA: 0x0025C534 File Offset: 0x0025A734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerSettingCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEMBICIIHNK_ != null)
			{
				if (this.bEMBICIIHNK_ == null)
				{
					this.BEMBICIIHNK = new OBONHLAFBFD();
				}
				this.BEMBICIIHNK.MergeFrom(other.BEMBICIIHNK);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E338 RID: 58168 RVA: 0x0025C588 File Offset: 0x0025A788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x0025C594 File Offset: 0x0025A794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.bEMBICIIHNK_ == null)
					{
						this.BEMBICIIHNK = new OBONHLAFBFD();
					}
					input.ReadMessage(this.BEMBICIIHNK);
				}
			}
		}

		// Token: 0x04005A52 RID: 23122
		private static readonly MessageParser<UpdatePlayerSettingCsReq> _parser = new MessageParser<UpdatePlayerSettingCsReq>(() => new UpdatePlayerSettingCsReq());

		// Token: 0x04005A53 RID: 23123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A54 RID: 23124
		public const int BEMBICIIHNKFieldNumber = 1;

		// Token: 0x04005A55 RID: 23125
		private OBONHLAFBFD bEMBICIIHNK_;
	}
}
