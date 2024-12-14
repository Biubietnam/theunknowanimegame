using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FDB RID: 4059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournHandBookNotify : IMessage<RogueTournHandBookNotify>, IMessage, IEquatable<RogueTournHandBookNotify>, IDeepCloneable<RogueTournHandBookNotify>, IBufferMessage
	{
		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x001E53CF File Offset: 0x001E35CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournHandBookNotify> Parser
		{
			get
			{
				return RogueTournHandBookNotify._parser;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x001E53D6 File Offset: 0x001E35D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournHandBookNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600B4D2 RID: 46290 RVA: 0x001E53E8 File Offset: 0x001E35E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournHandBookNotify.Descriptor;
			}
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x001E53EF File Offset: 0x001E35EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandBookNotify()
		{
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x001E5402 File Offset: 0x001E3602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandBookNotify(RogueTournHandBookNotify other) : this()
		{
			this.oMDLAICELCJ_ = other.oMDLAICELCJ_.Clone();
			this.iCDLBPPKNNK_ = other.iCDLBPPKNNK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x001E5438 File Offset: 0x001E3638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandBookNotify Clone()
		{
			return new RogueTournHandBookNotify(this);
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x001E5440 File Offset: 0x001E3640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OMDLAICELCJ
		{
			get
			{
				return this.oMDLAICELCJ_;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600B4D7 RID: 46295 RVA: 0x001E5448 File Offset: 0x001E3648
		// (set) Token: 0x0600B4D8 RID: 46296 RVA: 0x001E5450 File Offset: 0x001E3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournHandbookType ICDLBPPKNNK
		{
			get
			{
				return this.iCDLBPPKNNK_;
			}
			set
			{
				this.iCDLBPPKNNK_ = value;
			}
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x001E5459 File Offset: 0x001E3659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournHandBookNotify);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x001E5468 File Offset: 0x001E3668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournHandBookNotify other)
		{
			return other != null && (other == this || (this.oMDLAICELCJ_.Equals(other.oMDLAICELCJ_) && this.ICDLBPPKNNK == other.ICDLBPPKNNK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x001E54B8 File Offset: 0x001E36B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.oMDLAICELCJ_.GetHashCode();
			if (this.ICDLBPPKNNK != RogueTournHandbookType.RogueTournHandbookNone)
			{
				num ^= this.ICDLBPPKNNK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x001E550B File Offset: 0x001E370B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x001E5513 File Offset: 0x001E3713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x001E551C File Offset: 0x001E371C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oMDLAICELCJ_.WriteTo(ref output, RogueTournHandBookNotify._repeated_oMDLAICELCJ_codec);
			if (this.ICDLBPPKNNK != RogueTournHandbookType.RogueTournHandbookNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ICDLBPPKNNK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x001E556C File Offset: 0x001E376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.oMDLAICELCJ_.CalculateSize(RogueTournHandBookNotify._repeated_oMDLAICELCJ_codec);
			if (this.ICDLBPPKNNK != RogueTournHandbookType.RogueTournHandbookNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ICDLBPPKNNK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x001E55C0 File Offset: 0x001E37C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournHandBookNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.oMDLAICELCJ_.Add(other.oMDLAICELCJ_);
			if (other.ICDLBPPKNNK != RogueTournHandbookType.RogueTournHandbookNone)
			{
				this.ICDLBPPKNNK = other.ICDLBPPKNNK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x001E560D File Offset: 0x001E380D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x001E5618 File Offset: 0x001E3818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ICDLBPPKNNK = (RogueTournHandbookType)input.ReadEnum();
					}
				}
				else
				{
					this.oMDLAICELCJ_.AddEntriesFrom(ref input, RogueTournHandBookNotify._repeated_oMDLAICELCJ_codec);
				}
			}
		}

		// Token: 0x0400494B RID: 18763
		private static readonly MessageParser<RogueTournHandBookNotify> _parser = new MessageParser<RogueTournHandBookNotify>(() => new RogueTournHandBookNotify());

		// Token: 0x0400494C RID: 18764
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400494D RID: 18765
		public const int OMDLAICELCJFieldNumber = 3;

		// Token: 0x0400494E RID: 18766
		private static readonly FieldCodec<uint> _repeated_oMDLAICELCJ_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x0400494F RID: 18767
		private readonly RepeatedField<uint> oMDLAICELCJ_ = new RepeatedField<uint>();

		// Token: 0x04004950 RID: 18768
		public const int ICDLBPPKNNKFieldNumber = 15;

		// Token: 0x04004951 RID: 18769
		private RogueTournHandbookType iCDLBPPKNNK_;
	}
}
