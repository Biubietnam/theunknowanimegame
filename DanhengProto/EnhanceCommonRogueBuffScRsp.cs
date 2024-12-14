using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000425 RID: 1061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceCommonRogueBuffScRsp : IMessage<EnhanceCommonRogueBuffScRsp>, IMessage, IEquatable<EnhanceCommonRogueBuffScRsp>, IDeepCloneable<EnhanceCommonRogueBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00082347 File Offset: 0x00080547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceCommonRogueBuffScRsp> Parser
		{
			get
			{
				return EnhanceCommonRogueBuffScRsp._parser;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x0008234E File Offset: 0x0008054E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceCommonRogueBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00082360 File Offset: 0x00080560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceCommonRogueBuffScRsp.Descriptor;
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00082367 File Offset: 0x00080567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffScRsp()
		{
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00082370 File Offset: 0x00080570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffScRsp(EnhanceCommonRogueBuffScRsp other) : this()
		{
			this.rogueBuff_ = ((other.rogueBuff_ != null) ? other.rogueBuff_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.isSuccess_ = other.isSuccess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000823C8 File Offset: 0x000805C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceCommonRogueBuffScRsp Clone()
		{
			return new EnhanceCommonRogueBuffScRsp(this);
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000823D0 File Offset: 0x000805D0
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x000823D8 File Offset: 0x000805D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff RogueBuff
		{
			get
			{
				return this.rogueBuff_;
			}
			set
			{
				this.rogueBuff_ = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000823E1 File Offset: 0x000805E1
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x000823E9 File Offset: 0x000805E9
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

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000823F2 File Offset: 0x000805F2
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x000823FA File Offset: 0x000805FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00082403 File Offset: 0x00080603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceCommonRogueBuffScRsp);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00082414 File Offset: 0x00080614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceCommonRogueBuffScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueBuff, other.RogueBuff) && this.Retcode == other.Retcode && this.IsSuccess == other.IsSuccess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00082474 File Offset: 0x00080674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueBuff_ != null)
			{
				num ^= this.RogueBuff.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000824E2 File Offset: 0x000806E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000824EA File Offset: 0x000806EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000824F4 File Offset: 0x000806F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSuccess)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsSuccess);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueBuff_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueBuff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x0008256C File Offset: 0x0008076C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueBuff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuff);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000825D0 File Offset: 0x000807D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceCommonRogueBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueBuff_ != null)
			{
				if (this.rogueBuff_ == null)
				{
					this.RogueBuff = new RogueCommonBuff();
				}
				this.RogueBuff.MergeFrom(other.RogueBuff);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x0008264C File Offset: 0x0008084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00082658 File Offset: 0x00080858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueBuff_ == null)
							{
								this.RogueBuff = new RogueCommonBuff();
							}
							input.ReadMessage(this.RogueBuff);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.IsSuccess = input.ReadBool();
				}
			}
		}

		// Token: 0x040012E6 RID: 4838
		private static readonly MessageParser<EnhanceCommonRogueBuffScRsp> _parser = new MessageParser<EnhanceCommonRogueBuffScRsp>(() => new EnhanceCommonRogueBuffScRsp());

		// Token: 0x040012E7 RID: 4839
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012E8 RID: 4840
		public const int RogueBuffFieldNumber = 15;

		// Token: 0x040012E9 RID: 4841
		private RogueCommonBuff rogueBuff_;

		// Token: 0x040012EA RID: 4842
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040012EB RID: 4843
		private uint retcode_;

		// Token: 0x040012EC RID: 4844
		public const int IsSuccessFieldNumber = 5;

		// Token: 0x040012ED RID: 4845
		private bool isSuccess_;
	}
}
