using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000201 RID: 513
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCurrentInfo : IMessage<ChessRogueCurrentInfo>, IMessage, IEquatable<ChessRogueCurrentInfo>, IDeepCloneable<ChessRogueCurrentInfo>, IBufferMessage
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0004170F File Offset: 0x0003F90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCurrentInfo> Parser
		{
			get
			{
				return ChessRogueCurrentInfo._parser;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00041716 File Offset: 0x0003F916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCurrentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00041728 File Offset: 0x0003F928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCurrentInfo.Descriptor;
			}
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0004172F File Offset: 0x0003F92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentInfo()
		{
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00041742 File Offset: 0x0003F942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentInfo(ChessRogueCurrentInfo other) : this()
		{
			this.rogueSubMode_ = other.rogueSubMode_;
			this.rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00041778 File Offset: 0x0003F978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentInfo Clone()
		{
			return new ChessRogueCurrentInfo(this);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00041780 File Offset: 0x0003F980
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00041788 File Offset: 0x0003F988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueSubMode
		{
			get
			{
				return this.rogueSubMode_;
			}
			set
			{
				this.rogueSubMode_ = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00041791 File Offset: 0x0003F991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGameInfo> RogueCurrentGameInfo
		{
			get
			{
				return this.rogueCurrentGameInfo_;
			}
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00041799 File Offset: 0x0003F999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCurrentInfo);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000417A8 File Offset: 0x0003F9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCurrentInfo other)
		{
			return other != null && (other == this || (this.RogueSubMode == other.RogueSubMode && this.rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000417F8 File Offset: 0x0003F9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			num ^= this.rogueCurrentGameInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00041845 File Offset: 0x0003FA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0004184D File Offset: 0x0003FA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00041858 File Offset: 0x0003FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueCurrentGameInfo_.WriteTo(ref output, ChessRogueCurrentInfo._repeated_rogueCurrentGameInfo_codec);
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x000418A8 File Offset: 0x0003FAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			num += this.rogueCurrentGameInfo_.CalculateSize(ChessRogueCurrentInfo._repeated_rogueCurrentGameInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000418FC File Offset: 0x0003FAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCurrentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			this.rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00041949 File Offset: 0x0003FB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00041954 File Offset: 0x0003FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RogueSubMode = input.ReadUInt32();
					}
				}
				else
				{
					this.rogueCurrentGameInfo_.AddEntriesFrom(ref input, ChessRogueCurrentInfo._repeated_rogueCurrentGameInfo_codec);
				}
			}
		}

		// Token: 0x040009A1 RID: 2465
		private static readonly MessageParser<ChessRogueCurrentInfo> _parser = new MessageParser<ChessRogueCurrentInfo>(() => new ChessRogueCurrentInfo());

		// Token: 0x040009A2 RID: 2466
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009A3 RID: 2467
		public const int RogueSubModeFieldNumber = 14;

		// Token: 0x040009A4 RID: 2468
		private uint rogueSubMode_;

		// Token: 0x040009A5 RID: 2469
		public const int RogueCurrentGameInfoFieldNumber = 12;

		// Token: 0x040009A6 RID: 2470
		private static readonly FieldCodec<RogueGameInfo> _repeated_rogueCurrentGameInfo_codec = FieldCodec.ForMessage<RogueGameInfo>(98U, RogueGameInfo.Parser);

		// Token: 0x040009A7 RID: 2471
		private readonly RepeatedField<RogueGameInfo> rogueCurrentGameInfo_ = new RepeatedField<RogueGameInfo>();
	}
}
