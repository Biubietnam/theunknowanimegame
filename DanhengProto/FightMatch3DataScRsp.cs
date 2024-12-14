using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000549 RID: 1353
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3DataScRsp : IMessage<FightMatch3DataScRsp>, IMessage, IEquatable<FightMatch3DataScRsp>, IDeepCloneable<FightMatch3DataScRsp>, IBufferMessage
	{
		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x000A5373 File Offset: 0x000A3573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3DataScRsp> Parser
		{
			get
			{
				return FightMatch3DataScRsp._parser;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x000A537A File Offset: 0x000A357A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3DataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x000A538C File Offset: 0x000A358C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3DataScRsp.Descriptor;
			}
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x000A5393 File Offset: 0x000A3593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataScRsp()
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x000A53A8 File Offset: 0x000A35A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataScRsp(FightMatch3DataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x000A5405 File Offset: 0x000A3605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataScRsp Clone()
		{
			return new FightMatch3DataScRsp(this);
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x000A540D File Offset: 0x000A360D
		// (set) Token: 0x06003C4F RID: 15439 RVA: 0x000A5415 File Offset: 0x000A3615
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

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x000A541E File Offset: 0x000A361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x000A5426 File Offset: 0x000A3626
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x000A542E File Offset: 0x000A362E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x000A5437 File Offset: 0x000A3637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3DataScRsp);
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x000A5448 File Offset: 0x000A3648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3DataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x000A54AC File Offset: 0x000A36AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x000A550F File Offset: 0x000A370F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000A5517 File Offset: 0x000A3717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x000A5520 File Offset: 0x000A3720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eBMOKPBKMMD_.WriteTo(ref output, FightMatch3DataScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.data_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000A558C File Offset: 0x000A378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.eBMOKPBKMMD_.CalculateSize(FightMatch3DataScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x000A55F8 File Offset: 0x000A37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3DataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new CFHPMBOAHLA();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000A5671 File Offset: 0x000A3871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000A567C File Offset: 0x000A387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 48U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.data_ == null)
							{
								this.Data = new CFHPMBOAHLA();
							}
							input.ReadMessage(this.Data);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.eBMOKPBKMMD_.AddEntriesFrom(ref input, FightMatch3DataScRsp._repeated_eBMOKPBKMMD_codec);
				}
			}
		}

		// Token: 0x04001831 RID: 6193
		private static readonly MessageParser<FightMatch3DataScRsp> _parser = new MessageParser<FightMatch3DataScRsp>(() => new FightMatch3DataScRsp());

		// Token: 0x04001832 RID: 6194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001833 RID: 6195
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04001834 RID: 6196
		private uint retcode_;

		// Token: 0x04001835 RID: 6197
		public const int EBMOKPBKMMDFieldNumber = 3;

		// Token: 0x04001836 RID: 6198
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(26U, CCHCPNLPBDK.Parser);

		// Token: 0x04001837 RID: 6199
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04001838 RID: 6200
		public const int DataFieldNumber = 12;

		// Token: 0x04001839 RID: 6201
		private CFHPMBOAHLA data_;
	}
}
