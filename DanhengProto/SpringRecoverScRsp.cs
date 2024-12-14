using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117F RID: 4479
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRecoverScRsp : IMessage<SpringRecoverScRsp>, IMessage, IEquatable<SpringRecoverScRsp>, IDeepCloneable<SpringRecoverScRsp>, IBufferMessage
	{
		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600C7DB RID: 51163 RVA: 0x002183BD File Offset: 0x002165BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRecoverScRsp> Parser
		{
			get
			{
				return SpringRecoverScRsp._parser;
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600C7DC RID: 51164 RVA: 0x002183C4 File Offset: 0x002165C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRecoverScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600C7DD RID: 51165 RVA: 0x002183D6 File Offset: 0x002165D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRecoverScRsp.Descriptor;
			}
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x002183DD File Offset: 0x002165DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverScRsp()
		{
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x002183E8 File Offset: 0x002165E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverScRsp(SpringRecoverScRsp other) : this()
		{
			this.healPoolInfo_ = ((other.healPoolInfo_ != null) ? other.healPoolInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00218434 File Offset: 0x00216634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverScRsp Clone()
		{
			return new SpringRecoverScRsp(this);
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x0021843C File Offset: 0x0021663C
		// (set) Token: 0x0600C7E2 RID: 51170 RVA: 0x00218444 File Offset: 0x00216644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo HealPoolInfo
		{
			get
			{
				return this.healPoolInfo_;
			}
			set
			{
				this.healPoolInfo_ = value;
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600C7E3 RID: 51171 RVA: 0x0021844D File Offset: 0x0021664D
		// (set) Token: 0x0600C7E4 RID: 51172 RVA: 0x00218455 File Offset: 0x00216655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x0021845E File Offset: 0x0021665E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRecoverScRsp);
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x0021846C File Offset: 0x0021666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRecoverScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.HealPoolInfo, other.HealPoolInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x002184BC File Offset: 0x002166BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.healPoolInfo_ != null)
			{
				num ^= this.HealPoolInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x00218511 File Offset: 0x00216711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x00218519 File Offset: 0x00216719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x00218524 File Offset: 0x00216724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.healPoolInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.HealPoolInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x00218580 File Offset: 0x00216780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.healPoolInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HealPoolInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7EC RID: 51180 RVA: 0x002185D8 File Offset: 0x002167D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRecoverScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.healPoolInfo_ != null)
			{
				if (this.healPoolInfo_ == null)
				{
					this.HealPoolInfo = new HealPoolInfo();
				}
				this.HealPoolInfo.MergeFrom(other.HealPoolInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7ED RID: 51181 RVA: 0x00218640 File Offset: 0x00216840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x0021864C File Offset: 0x0021684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.healPoolInfo_ == null)
					{
						this.HealPoolInfo = new HealPoolInfo();
					}
					input.ReadMessage(this.HealPoolInfo);
				}
			}
		}

		// Token: 0x040050B3 RID: 20659
		private static readonly MessageParser<SpringRecoverScRsp> _parser = new MessageParser<SpringRecoverScRsp>(() => new SpringRecoverScRsp());

		// Token: 0x040050B4 RID: 20660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050B5 RID: 20661
		public const int HealPoolInfoFieldNumber = 10;

		// Token: 0x040050B6 RID: 20662
		private HealPoolInfo healPoolInfo_;

		// Token: 0x040050B7 RID: 20663
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040050B8 RID: 20664
		private uint retcode_;
	}
}
