using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200133B RID: 4923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTalkRewardScRsp : IMessage<TakeTalkRewardScRsp>, IMessage, IEquatable<TakeTalkRewardScRsp>, IDeepCloneable<TakeTalkRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x00249281 File Offset: 0x00247481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTalkRewardScRsp> Parser
		{
			get
			{
				return TakeTalkRewardScRsp._parser;
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x00249288 File Offset: 0x00247488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTalkRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600DBB4 RID: 56244 RVA: 0x0024929A File Offset: 0x0024749A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTalkRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x002492A1 File Offset: 0x002474A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardScRsp()
		{
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x002492AC File Offset: 0x002474AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardScRsp(TakeTalkRewardScRsp other) : this()
		{
			this.mMKIANLHPLJ_ = other.mMKIANLHPLJ_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00249304 File Offset: 0x00247504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardScRsp Clone()
		{
			return new TakeTalkRewardScRsp(this);
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600DBB8 RID: 56248 RVA: 0x0024930C File Offset: 0x0024750C
		// (set) Token: 0x0600DBB9 RID: 56249 RVA: 0x00249314 File Offset: 0x00247514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMKIANLHPLJ
		{
			get
			{
				return this.mMKIANLHPLJ_;
			}
			set
			{
				this.mMKIANLHPLJ_ = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x0024931D File Offset: 0x0024751D
		// (set) Token: 0x0600DBBB RID: 56251 RVA: 0x00249325 File Offset: 0x00247525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600DBBC RID: 56252 RVA: 0x0024932E File Offset: 0x0024752E
		// (set) Token: 0x0600DBBD RID: 56253 RVA: 0x00249336 File Offset: 0x00247536
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

		// Token: 0x0600DBBE RID: 56254 RVA: 0x0024933F File Offset: 0x0024753F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTalkRewardScRsp);
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x00249350 File Offset: 0x00247550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTalkRewardScRsp other)
		{
			return other != null && (other == this || (this.MMKIANLHPLJ == other.MMKIANLHPLJ && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x002493B0 File Offset: 0x002475B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMKIANLHPLJ != 0U)
			{
				num ^= this.MMKIANLHPLJ.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
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

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x0024941E File Offset: 0x0024761E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00249426 File Offset: 0x00247626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00249430 File Offset: 0x00247630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MMKIANLHPLJ != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MMKIANLHPLJ);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x002494A8 File Offset: 0x002476A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMKIANLHPLJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMKIANLHPLJ);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
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

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x00249518 File Offset: 0x00247718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTalkRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMKIANLHPLJ != 0U)
			{
				this.MMKIANLHPLJ = other.MMKIANLHPLJ;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x00249594 File Offset: 0x00247794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBC7 RID: 56263 RVA: 0x002495A0 File Offset: 0x002477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 114U)
					{
						if (num != 120U)
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
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
					}
				}
				else
				{
					this.MMKIANLHPLJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005774 RID: 22388
		private static readonly MessageParser<TakeTalkRewardScRsp> _parser = new MessageParser<TakeTalkRewardScRsp>(() => new TakeTalkRewardScRsp());

		// Token: 0x04005775 RID: 22389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005776 RID: 22390
		public const int MMKIANLHPLJFieldNumber = 8;

		// Token: 0x04005777 RID: 22391
		private uint mMKIANLHPLJ_;

		// Token: 0x04005778 RID: 22392
		public const int RewardFieldNumber = 14;

		// Token: 0x04005779 RID: 22393
		private ItemList reward_;

		// Token: 0x0400577A RID: 22394
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400577B RID: 22395
		private uint retcode_;
	}
}
