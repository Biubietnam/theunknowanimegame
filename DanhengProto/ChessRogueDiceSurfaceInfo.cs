using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000209 RID: 521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueDiceSurfaceInfo : IMessage<ChessRogueDiceSurfaceInfo>, IMessage, IEquatable<ChessRogueDiceSurfaceInfo>, IDeepCloneable<ChessRogueDiceSurfaceInfo>, IBufferMessage
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00042F05 File Offset: 0x00041105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueDiceSurfaceInfo> Parser
		{
			get
			{
				return ChessRogueDiceSurfaceInfo._parser;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00042F0C File Offset: 0x0004110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceSurfaceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00042F1E File Offset: 0x0004111E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueDiceSurfaceInfo.Descriptor;
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00042F25 File Offset: 0x00041125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceSurfaceInfo()
		{
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00042F2D File Offset: 0x0004112D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceSurfaceInfo(ChessRogueDiceSurfaceInfo other) : this()
		{
			this.diceSurfaceId_ = other.diceSurfaceId_;
			this.diceSlotId_ = other.diceSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00042F5E File Offset: 0x0004115E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceSurfaceInfo Clone()
		{
			return new ChessRogueDiceSurfaceInfo(this);
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00042F66 File Offset: 0x00041166
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x00042F6E File Offset: 0x0004116E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSurfaceId
		{
			get
			{
				return this.diceSurfaceId_;
			}
			set
			{
				this.diceSurfaceId_ = value;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00042F77 File Offset: 0x00041177
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00042F7F File Offset: 0x0004117F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSlotId
		{
			get
			{
				return this.diceSlotId_;
			}
			set
			{
				this.diceSlotId_ = value;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00042F88 File Offset: 0x00041188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueDiceSurfaceInfo);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00042F96 File Offset: 0x00041196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueDiceSurfaceInfo other)
		{
			return other != null && (other == this || (this.DiceSurfaceId == other.DiceSurfaceId && this.DiceSlotId == other.DiceSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00042FD4 File Offset: 0x000411D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiceSurfaceId != 0U)
			{
				num ^= this.DiceSurfaceId.GetHashCode();
			}
			if (this.DiceSlotId != 0U)
			{
				num ^= this.DiceSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0004302C File Offset: 0x0004122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00043034 File Offset: 0x00041234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00043040 File Offset: 0x00041240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiceSurfaceId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DiceSurfaceId);
			}
			if (this.DiceSlotId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DiceSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0004309C File Offset: 0x0004129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiceSurfaceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSurfaceId);
			}
			if (this.DiceSlotId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000430F4 File Offset: 0x000412F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueDiceSurfaceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiceSurfaceId != 0U)
			{
				this.DiceSurfaceId = other.DiceSurfaceId;
			}
			if (other.DiceSlotId != 0U)
			{
				this.DiceSlotId = other.DiceSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00043144 File Offset: 0x00041344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00043150 File Offset: 0x00041350
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DiceSlotId = input.ReadUInt32();
					}
				}
				else
				{
					this.DiceSurfaceId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly MessageParser<ChessRogueDiceSurfaceInfo> _parser = new MessageParser<ChessRogueDiceSurfaceInfo>(() => new ChessRogueDiceSurfaceInfo());

		// Token: 0x040009E2 RID: 2530
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009E3 RID: 2531
		public const int DiceSurfaceIdFieldNumber = 5;

		// Token: 0x040009E4 RID: 2532
		private uint diceSurfaceId_;

		// Token: 0x040009E5 RID: 2533
		public const int DiceSlotIdFieldNumber = 9;

		// Token: 0x040009E6 RID: 2534
		private uint diceSlotId_;
	}
}
