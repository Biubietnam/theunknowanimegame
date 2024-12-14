using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001283 RID: 4739
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueCommonActionResultScNotify : IMessage<SyncRogueCommonActionResultScNotify>, IMessage, IEquatable<SyncRogueCommonActionResultScNotify>, IDeepCloneable<SyncRogueCommonActionResultScNotify>, IBufferMessage
	{
		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600D36D RID: 54125 RVA: 0x00234A37 File Offset: 0x00232C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueCommonActionResultScNotify> Parser
		{
			get
			{
				return SyncRogueCommonActionResultScNotify._parser;
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x00234A3E File Offset: 0x00232C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonActionResultScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600D36F RID: 54127 RVA: 0x00234A50 File Offset: 0x00232C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueCommonActionResultScNotify.Descriptor;
			}
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x00234A57 File Offset: 0x00232C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonActionResultScNotify()
		{
		}

		// Token: 0x0600D371 RID: 54129 RVA: 0x00234A6C File Offset: 0x00232C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonActionResultScNotify(SyncRogueCommonActionResultScNotify other) : this()
		{
			this.displayType_ = other.displayType_;
			this.actionResultList_ = other.actionResultList_.Clone();
			this.rogueSubMode_ = other.rogueSubMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D372 RID: 54130 RVA: 0x00234AB9 File Offset: 0x00232CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonActionResultScNotify Clone()
		{
			return new SyncRogueCommonActionResultScNotify(this);
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600D373 RID: 54131 RVA: 0x00234AC1 File Offset: 0x00232CC1
		// (set) Token: 0x0600D374 RID: 54132 RVA: 0x00234AC9 File Offset: 0x00232CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultDisplayType DisplayType
		{
			get
			{
				return this.displayType_;
			}
			set
			{
				this.displayType_ = value;
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x00234AD2 File Offset: 0x00232CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonActionResult> ActionResultList
		{
			get
			{
				return this.actionResultList_;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600D376 RID: 54134 RVA: 0x00234ADA File Offset: 0x00232CDA
		// (set) Token: 0x0600D377 RID: 54135 RVA: 0x00234AE2 File Offset: 0x00232CE2
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

		// Token: 0x0600D378 RID: 54136 RVA: 0x00234AEB File Offset: 0x00232CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueCommonActionResultScNotify);
		}

		// Token: 0x0600D379 RID: 54137 RVA: 0x00234AFC File Offset: 0x00232CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueCommonActionResultScNotify other)
		{
			return other != null && (other == this || (this.DisplayType == other.DisplayType && this.actionResultList_.Equals(other.actionResultList_) && this.RogueSubMode == other.RogueSubMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D37A RID: 54138 RVA: 0x00234B5C File Offset: 0x00232D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisplayType != RogueCommonActionResultDisplayType.None)
			{
				num ^= this.DisplayType.GetHashCode();
			}
			num ^= this.actionResultList_.GetHashCode();
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D37B RID: 54139 RVA: 0x00234BC8 File Offset: 0x00232DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D37C RID: 54140 RVA: 0x00234BD0 File Offset: 0x00232DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x00234BDC File Offset: 0x00232DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this.DisplayType != RogueCommonActionResultDisplayType.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.DisplayType);
			}
			this.actionResultList_.WriteTo(ref output, SyncRogueCommonActionResultScNotify._repeated_actionResultList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D37E RID: 54142 RVA: 0x00234C48 File Offset: 0x00232E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisplayType != RogueCommonActionResultDisplayType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DisplayType);
			}
			num += this.actionResultList_.CalculateSize(SyncRogueCommonActionResultScNotify._repeated_actionResultList_codec);
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D37F RID: 54143 RVA: 0x00234CB4 File Offset: 0x00232EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueCommonActionResultScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisplayType != RogueCommonActionResultDisplayType.None)
			{
				this.DisplayType = other.DisplayType;
			}
			this.actionResultList_.Add(other.actionResultList_);
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D380 RID: 54144 RVA: 0x00234D15 File Offset: 0x00232F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x00234D20 File Offset: 0x00232F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.actionResultList_.AddEntriesFrom(ref input, SyncRogueCommonActionResultScNotify._repeated_actionResultList_codec);
						}
					}
					else
					{
						this.DisplayType = (RogueCommonActionResultDisplayType)input.ReadEnum();
					}
				}
				else
				{
					this.RogueSubMode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040054A5 RID: 21669
		private static readonly MessageParser<SyncRogueCommonActionResultScNotify> _parser = new MessageParser<SyncRogueCommonActionResultScNotify>(() => new SyncRogueCommonActionResultScNotify());

		// Token: 0x040054A6 RID: 21670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A7 RID: 21671
		public const int DisplayTypeFieldNumber = 9;

		// Token: 0x040054A8 RID: 21672
		private RogueCommonActionResultDisplayType displayType_;

		// Token: 0x040054A9 RID: 21673
		public const int ActionResultListFieldNumber = 13;

		// Token: 0x040054AA RID: 21674
		private static readonly FieldCodec<RogueCommonActionResult> _repeated_actionResultList_codec = FieldCodec.ForMessage<RogueCommonActionResult>(106U, RogueCommonActionResult.Parser);

		// Token: 0x040054AB RID: 21675
		private readonly RepeatedField<RogueCommonActionResult> actionResultList_ = new RepeatedField<RogueCommonActionResult>();

		// Token: 0x040054AC RID: 21676
		public const int RogueSubModeFieldNumber = 8;

		// Token: 0x040054AD RID: 21677
		private uint rogueSubMode_;
	}
}
