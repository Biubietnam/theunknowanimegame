using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000495 RID: 1173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EquipAetherDividePassiveSkillScRsp : IMessage<EquipAetherDividePassiveSkillScRsp>, IMessage, IEquatable<EquipAetherDividePassiveSkillScRsp>, IDeepCloneable<EquipAetherDividePassiveSkillScRsp>, IBufferMessage
	{
		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x0008F2D7 File Offset: 0x0008D4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipAetherDividePassiveSkillScRsp> Parser
		{
			get
			{
				return EquipAetherDividePassiveSkillScRsp._parser;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x0008F2DE File Offset: 0x0008D4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x0008F2F0 File Offset: 0x0008D4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillScRsp.Descriptor;
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x0008F2F7 File Offset: 0x0008D4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillScRsp()
		{
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x0008F300 File Offset: 0x0008D500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillScRsp(EquipAetherDividePassiveSkillScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.aetherInfo_ = ((other.aetherInfo_ != null) ? other.aetherInfo_.Clone() : null);
			this.aetherSkillInfo_ = ((other.aetherSkillInfo_ != null) ? other.aetherSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x0008F368 File Offset: 0x0008D568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipAetherDividePassiveSkillScRsp Clone()
		{
			return new EquipAetherDividePassiveSkillScRsp(this);
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x0008F370 File Offset: 0x0008D570
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x0008F378 File Offset: 0x0008D578
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x0008F381 File Offset: 0x0008D581
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x0008F389 File Offset: 0x0008D589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo AetherInfo
		{
			get
			{
				return this.aetherInfo_;
			}
			set
			{
				this.aetherInfo_ = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x0008F392 File Offset: 0x0008D592
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x0008F39A File Offset: 0x0008D59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherSkillInfo AetherSkillInfo
		{
			get
			{
				return this.aetherSkillInfo_;
			}
			set
			{
				this.aetherSkillInfo_ = value;
			}
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x0008F3A3 File Offset: 0x0008D5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipAetherDividePassiveSkillScRsp);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x0008F3B4 File Offset: 0x0008D5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipAetherDividePassiveSkillScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.AetherInfo, other.AetherInfo) && object.Equals(this.AetherSkillInfo, other.AetherSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x0008F418 File Offset: 0x0008D618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.aetherInfo_ != null)
			{
				num ^= this.AetherInfo.GetHashCode();
			}
			if (this.aetherSkillInfo_ != null)
			{
				num ^= this.AetherSkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x0008F483 File Offset: 0x0008D683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x0008F48B File Offset: 0x0008D68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x0008F494 File Offset: 0x0008D694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.aetherSkillInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.AetherSkillInfo);
			}
			if (this.aetherInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.AetherInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x0008F50C File Offset: 0x0008D70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.aetherInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherInfo);
			}
			if (this.aetherSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x0008F57C File Offset: 0x0008D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipAetherDividePassiveSkillScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.aetherInfo_ != null)
			{
				if (this.aetherInfo_ == null)
				{
					this.AetherInfo = new AetherDivideSpiritInfo();
				}
				this.AetherInfo.MergeFrom(other.AetherInfo);
			}
			if (other.aetherSkillInfo_ != null)
			{
				if (this.aetherSkillInfo_ == null)
				{
					this.AetherSkillInfo = new AetherSkillInfo();
				}
				this.AetherSkillInfo.MergeFrom(other.AetherSkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x0008F610 File Offset: 0x0008D810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x0008F61C File Offset: 0x0008D81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 98U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.aetherInfo_ == null)
							{
								this.AetherInfo = new AetherDivideSpiritInfo();
							}
							input.ReadMessage(this.AetherInfo);
						}
					}
					else
					{
						if (this.aetherSkillInfo_ == null)
						{
							this.AetherSkillInfo = new AetherSkillInfo();
						}
						input.ReadMessage(this.AetherSkillInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014B3 RID: 5299
		private static readonly MessageParser<EquipAetherDividePassiveSkillScRsp> _parser = new MessageParser<EquipAetherDividePassiveSkillScRsp>(() => new EquipAetherDividePassiveSkillScRsp());

		// Token: 0x040014B4 RID: 5300
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014B5 RID: 5301
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040014B6 RID: 5302
		private uint retcode_;

		// Token: 0x040014B7 RID: 5303
		public const int AetherInfoFieldNumber = 13;

		// Token: 0x040014B8 RID: 5304
		private AetherDivideSpiritInfo aetherInfo_;

		// Token: 0x040014B9 RID: 5305
		public const int AetherSkillInfoFieldNumber = 12;

		// Token: 0x040014BA RID: 5306
		private AetherSkillInfo aetherSkillInfo_;
	}
}
