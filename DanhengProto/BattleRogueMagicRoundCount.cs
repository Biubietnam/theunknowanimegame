using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FD RID: 253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicRoundCount : IMessage<BattleRogueMagicRoundCount>, IMessage, IEquatable<BattleRogueMagicRoundCount>, IDeepCloneable<BattleRogueMagicRoundCount>, IBufferMessage
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000215E1 File Offset: 0x0001F7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicRoundCount> Parser
		{
			get
			{
				return BattleRogueMagicRoundCount._parser;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000215E8 File Offset: 0x0001F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicRoundCountReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000215FA File Offset: 0x0001F7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicRoundCount.Descriptor;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00021601 File Offset: 0x0001F801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicRoundCount()
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00021609 File Offset: 0x0001F809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicRoundCount(BattleRogueMagicRoundCount other) : this()
		{
			this.battleStandardRoundLimit_ = other.battleStandardRoundLimit_;
			this.battleExtraRoundLimit_ = other.battleExtraRoundLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002163A File Offset: 0x0001F83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicRoundCount Clone()
		{
			return new BattleRogueMagicRoundCount(this);
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00021642 File Offset: 0x0001F842
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x0002164A File Offset: 0x0001F84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleStandardRoundLimit
		{
			get
			{
				return this.battleStandardRoundLimit_;
			}
			set
			{
				this.battleStandardRoundLimit_ = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00021653 File Offset: 0x0001F853
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0002165B File Offset: 0x0001F85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleExtraRoundLimit
		{
			get
			{
				return this.battleExtraRoundLimit_;
			}
			set
			{
				this.battleExtraRoundLimit_ = value;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00021664 File Offset: 0x0001F864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicRoundCount);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00021672 File Offset: 0x0001F872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicRoundCount other)
		{
			return other != null && (other == this || (this.BattleStandardRoundLimit == other.BattleStandardRoundLimit && this.BattleExtraRoundLimit == other.BattleExtraRoundLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000216B0 File Offset: 0x0001F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleStandardRoundLimit != 0U)
			{
				num ^= this.BattleStandardRoundLimit.GetHashCode();
			}
			if (this.BattleExtraRoundLimit != 0U)
			{
				num ^= this.BattleExtraRoundLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00021708 File Offset: 0x0001F908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00021710 File Offset: 0x0001F910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002171C File Offset: 0x0001F91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleStandardRoundLimit != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BattleStandardRoundLimit);
			}
			if (this.BattleExtraRoundLimit != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BattleExtraRoundLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00021774 File Offset: 0x0001F974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleStandardRoundLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleStandardRoundLimit);
			}
			if (this.BattleExtraRoundLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleExtraRoundLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000217CC File Offset: 0x0001F9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicRoundCount other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleStandardRoundLimit != 0U)
			{
				this.BattleStandardRoundLimit = other.BattleStandardRoundLimit;
			}
			if (other.BattleExtraRoundLimit != 0U)
			{
				this.BattleExtraRoundLimit = other.BattleExtraRoundLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002181C File Offset: 0x0001FA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00021828 File Offset: 0x0001FA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BattleExtraRoundLimit = input.ReadUInt32();
					}
				}
				else
				{
					this.BattleStandardRoundLimit = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040004BC RID: 1212
		private static readonly MessageParser<BattleRogueMagicRoundCount> _parser = new MessageParser<BattleRogueMagicRoundCount>(() => new BattleRogueMagicRoundCount());

		// Token: 0x040004BD RID: 1213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004BE RID: 1214
		public const int BattleStandardRoundLimitFieldNumber = 1;

		// Token: 0x040004BF RID: 1215
		private uint battleStandardRoundLimit_;

		// Token: 0x040004C0 RID: 1216
		public const int BattleExtraRoundLimitFieldNumber = 2;

		// Token: 0x040004C1 RID: 1217
		private uint battleExtraRoundLimit_;
	}
}
