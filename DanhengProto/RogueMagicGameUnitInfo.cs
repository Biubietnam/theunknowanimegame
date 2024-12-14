using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EDB RID: 3803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameUnitInfo : IMessage<RogueMagicGameUnitInfo>, IMessage, IEquatable<RogueMagicGameUnitInfo>, IDeepCloneable<RogueMagicGameUnitInfo>, IBufferMessage
	{
		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x001CA017 File Offset: 0x001C8217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameUnitInfo> Parser
		{
			get
			{
				return RogueMagicGameUnitInfo._parser;
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x001CA01E File Offset: 0x001C821E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameUnitInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600AA02 RID: 43522 RVA: 0x001CA030 File Offset: 0x001C8230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameUnitInfo.Descriptor;
			}
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x001CA037 File Offset: 0x001C8237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo()
		{
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x001CA040 File Offset: 0x001C8240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo(RogueMagicGameUnitInfo other) : this()
		{
			this.gameMagicUnit_ = ((other.gameMagicUnit_ != null) ? other.gameMagicUnit_.Clone() : null);
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x001CA08C File Offset: 0x001C828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo Clone()
		{
			return new RogueMagicGameUnitInfo(this);
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x001CA094 File Offset: 0x001C8294
		// (set) Token: 0x0600AA07 RID: 43527 RVA: 0x001CA09C File Offset: 0x001C829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit GameMagicUnit
		{
			get
			{
				return this.gameMagicUnit_;
			}
			set
			{
				this.gameMagicUnit_ = value;
			}
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x001CA0A5 File Offset: 0x001C82A5
		// (set) Token: 0x0600AA09 RID: 43529 RVA: 0x001CA0AD File Offset: 0x001C82AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x001CA0B6 File Offset: 0x001C82B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameUnitInfo);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x001CA0C4 File Offset: 0x001C82C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameUnitInfo other)
		{
			return other != null && (other == this || (object.Equals(this.GameMagicUnit, other.GameMagicUnit) && this.UniqueId == other.UniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x001CA114 File Offset: 0x001C8314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameMagicUnit_ != null)
			{
				num ^= this.GameMagicUnit.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x001CA169 File Offset: 0x001C8369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x001CA171 File Offset: 0x001C8371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x001CA17C File Offset: 0x001C837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameMagicUnit_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GameMagicUnit);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x001CA1D8 File Offset: 0x001C83D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gameMagicUnit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMagicUnit);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x001CA230 File Offset: 0x001C8430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameUnitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gameMagicUnit_ != null)
			{
				if (this.gameMagicUnit_ == null)
				{
					this.GameMagicUnit = new RogueMagicGameUnit();
				}
				this.GameMagicUnit.MergeFrom(other.GameMagicUnit);
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x001CA298 File Offset: 0x001C8498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x001CA2A4 File Offset: 0x001C84A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UniqueId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.gameMagicUnit_ == null)
					{
						this.GameMagicUnit = new RogueMagicGameUnit();
					}
					input.ReadMessage(this.GameMagicUnit);
				}
			}
		}

		// Token: 0x04004569 RID: 17769
		private static readonly MessageParser<RogueMagicGameUnitInfo> _parser = new MessageParser<RogueMagicGameUnitInfo>(() => new RogueMagicGameUnitInfo());

		// Token: 0x0400456A RID: 17770
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400456B RID: 17771
		public const int GameMagicUnitFieldNumber = 6;

		// Token: 0x0400456C RID: 17772
		private RogueMagicGameUnit gameMagicUnit_;

		// Token: 0x0400456D RID: 17773
		public const int UniqueIdFieldNumber = 9;

		// Token: 0x0400456E RID: 17774
		private uint uniqueId_;
	}
}
