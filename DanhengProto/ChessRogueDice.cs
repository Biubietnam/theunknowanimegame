using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000203 RID: 515
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueDice : IMessage<ChessRogueDice>, IMessage, IEquatable<ChessRogueDice>, IDeepCloneable<ChessRogueDice>, IBufferMessage
	{
		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00041A8B File Offset: 0x0003FC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueDice> Parser
		{
			get
			{
				return ChessRogueDice._parser;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00041A92 File Offset: 0x0003FC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00041AA4 File Offset: 0x0003FCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueDice.Descriptor;
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00041AAB File Offset: 0x0003FCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice(ChessRogueDice other) : this()
		{
			this.branchId_ = other.branchId_;
			this.surfaceList_ = other.surfaceList_.Clone();
			this.surfaceId_ = other.surfaceId_;
			this.slotId_ = other.slotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00041B19 File Offset: 0x0003FD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice Clone()
		{
			return new ChessRogueDice(this);
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00041B21 File Offset: 0x0003FD21
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x00041B29 File Offset: 0x0003FD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BranchId
		{
			get
			{
				return this.branchId_;
			}
			set
			{
				this.branchId_ = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00041B32 File Offset: 0x0003FD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueDiceSurfaceInfo> SurfaceList
		{
			get
			{
				return this.surfaceList_;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00041B3A File Offset: 0x0003FD3A
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00041B42 File Offset: 0x0003FD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SurfaceId
		{
			get
			{
				return this.surfaceId_;
			}
			set
			{
				this.surfaceId_ = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00041B4B File Offset: 0x0003FD4B
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00041B53 File Offset: 0x0003FD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00041B5C File Offset: 0x0003FD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueDice);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00041B6C File Offset: 0x0003FD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueDice other)
		{
			return other != null && (other == this || (this.BranchId == other.BranchId && this.surfaceList_.Equals(other.surfaceList_) && this.SurfaceId == other.SurfaceId && this.SlotId == other.SlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00041BDC File Offset: 0x0003FDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BranchId != 0U)
			{
				num ^= this.BranchId.GetHashCode();
			}
			num ^= this.surfaceList_.GetHashCode();
			if (this.SurfaceId != 0U)
			{
				num ^= this.SurfaceId.GetHashCode();
			}
			if (this.SlotId != 0U)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00041C5B File Offset: 0x0003FE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00041C63 File Offset: 0x0003FE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00041C6C File Offset: 0x0003FE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.surfaceList_.WriteTo(ref output, ChessRogueDice._repeated_surfaceList_codec);
			if (this.SurfaceId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SurfaceId);
			}
			if (this.BranchId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BranchId);
			}
			if (this.SlotId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00041CF4 File Offset: 0x0003FEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BranchId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BranchId);
			}
			num += this.surfaceList_.CalculateSize(ChessRogueDice._repeated_surfaceList_codec);
			if (this.SurfaceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SurfaceId);
			}
			if (this.SlotId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00041D78 File Offset: 0x0003FF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueDice other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BranchId != 0U)
			{
				this.BranchId = other.BranchId;
			}
			this.surfaceList_.Add(other.surfaceList_);
			if (other.SurfaceId != 0U)
			{
				this.SurfaceId = other.SurfaceId;
			}
			if (other.SlotId != 0U)
			{
				this.SlotId = other.SlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00041DED File Offset: 0x0003FFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00041DF8 File Offset: 0x0003FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 34U)
					{
						this.surfaceList_.AddEntriesFrom(ref input, ChessRogueDice._repeated_surfaceList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.SurfaceId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BranchId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.SlotId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009A9 RID: 2473
		private static readonly MessageParser<ChessRogueDice> _parser = new MessageParser<ChessRogueDice>(() => new ChessRogueDice());

		// Token: 0x040009AA RID: 2474
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009AB RID: 2475
		public const int BranchIdFieldNumber = 7;

		// Token: 0x040009AC RID: 2476
		private uint branchId_;

		// Token: 0x040009AD RID: 2477
		public const int SurfaceListFieldNumber = 4;

		// Token: 0x040009AE RID: 2478
		private static readonly FieldCodec<ChessRogueDiceSurfaceInfo> _repeated_surfaceList_codec = FieldCodec.ForMessage<ChessRogueDiceSurfaceInfo>(34U, ChessRogueDiceSurfaceInfo.Parser);

		// Token: 0x040009AF RID: 2479
		private readonly RepeatedField<ChessRogueDiceSurfaceInfo> surfaceList_ = new RepeatedField<ChessRogueDiceSurfaceInfo>();

		// Token: 0x040009B0 RID: 2480
		public const int SurfaceIdFieldNumber = 6;

		// Token: 0x040009B1 RID: 2481
		private uint surfaceId_;

		// Token: 0x040009B2 RID: 2482
		public const int SlotIdFieldNumber = 9;

		// Token: 0x040009B3 RID: 2483
		private uint slotId_;
	}
}
