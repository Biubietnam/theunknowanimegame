using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001207 RID: 4615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SummonActivityBattleEndScNotify : IMessage<SummonActivityBattleEndScNotify>, IMessage, IEquatable<SummonActivityBattleEndScNotify>, IDeepCloneable<SummonActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x00229573 File Offset: 0x00227773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SummonActivityBattleEndScNotify> Parser
		{
			get
			{
				return SummonActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600CE44 RID: 52804 RVA: 0x0022957A File Offset: 0x0022777A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SummonActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0022958C File Offset: 0x0022778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x00229593 File Offset: 0x00227793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonActivityBattleEndScNotify()
		{
		}

		// Token: 0x0600CE47 RID: 52807 RVA: 0x0022959C File Offset: 0x0022779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonActivityBattleEndScNotify(SummonActivityBattleEndScNotify other) : this()
		{
			this.groupId_ = other.groupId_;
			this.bELGPLFBDBP_ = other.bELGPLFBDBP_;
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.star_ = other.star_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE48 RID: 52808 RVA: 0x002295F0 File Offset: 0x002277F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonActivityBattleEndScNotify Clone()
		{
			return new SummonActivityBattleEndScNotify(this);
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x002295F8 File Offset: 0x002277F8
		// (set) Token: 0x0600CE4A RID: 52810 RVA: 0x00229600 File Offset: 0x00227800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x00229609 File Offset: 0x00227809
		// (set) Token: 0x0600CE4C RID: 52812 RVA: 0x00229611 File Offset: 0x00227811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BELGPLFBDBP
		{
			get
			{
				return this.bELGPLFBDBP_;
			}
			set
			{
				this.bELGPLFBDBP_ = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x0022961A File Offset: 0x0022781A
		// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x00229622 File Offset: 0x00227822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x0022962B File Offset: 0x0022782B
		// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x00229633 File Offset: 0x00227833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x0022963C File Offset: 0x0022783C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonActivityBattleEndScNotify);
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x0022964C File Offset: 0x0022784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.BELGPLFBDBP == other.BELGPLFBDBP && this.AHFNGPLDAII == other.AHFNGPLDAII && this.Star == other.Star && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE53 RID: 52819 RVA: 0x002296B8 File Offset: 0x002278B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.BELGPLFBDBP != 0U)
			{
				num ^= this.BELGPLFBDBP.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE54 RID: 52820 RVA: 0x00229742 File Offset: 0x00227942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE55 RID: 52821 RVA: 0x0022974A File Offset: 0x0022794A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x00229754 File Offset: 0x00227954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GroupId);
			}
			if (this.Star != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Star);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.BELGPLFBDBP != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.BELGPLFBDBP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE57 RID: 52823 RVA: 0x002297E8 File Offset: 0x002279E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.BELGPLFBDBP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BELGPLFBDBP);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE58 RID: 52824 RVA: 0x00229870 File Offset: 0x00227A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.BELGPLFBDBP != 0U)
			{
				this.BELGPLFBDBP = other.BELGPLFBDBP;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE59 RID: 52825 RVA: 0x002298E8 File Offset: 0x00227AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE5A RID: 52826 RVA: 0x002298F4 File Offset: 0x00227AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Star = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BELGPLFBDBP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005319 RID: 21273
		private static readonly MessageParser<SummonActivityBattleEndScNotify> _parser = new MessageParser<SummonActivityBattleEndScNotify>(() => new SummonActivityBattleEndScNotify());

		// Token: 0x0400531A RID: 21274
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400531B RID: 21275
		public const int GroupIdFieldNumber = 2;

		// Token: 0x0400531C RID: 21276
		private uint groupId_;

		// Token: 0x0400531D RID: 21277
		public const int BELGPLFBDBPFieldNumber = 15;

		// Token: 0x0400531E RID: 21278
		private uint bELGPLFBDBP_;

		// Token: 0x0400531F RID: 21279
		public const int AHFNGPLDAIIFieldNumber = 5;

		// Token: 0x04005320 RID: 21280
		private uint aHFNGPLDAII_;

		// Token: 0x04005321 RID: 21281
		public const int StarFieldNumber = 4;

		// Token: 0x04005322 RID: 21282
		private uint star_;
	}
}
