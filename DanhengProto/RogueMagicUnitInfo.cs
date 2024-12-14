using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F2D RID: 3885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitInfo : IMessage<RogueMagicUnitInfo>, IMessage, IEquatable<RogueMagicUnitInfo>, IDeepCloneable<RogueMagicUnitInfo>, IBufferMessage
	{
		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x001D22CD File Offset: 0x001D04CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitInfo> Parser
		{
			get
			{
				return RogueMagicUnitInfo._parser;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600AD53 RID: 44371 RVA: 0x001D22D4 File Offset: 0x001D04D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600AD54 RID: 44372 RVA: 0x001D22E6 File Offset: 0x001D04E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitInfo.Descriptor;
			}
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x001D22ED File Offset: 0x001D04ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitInfo()
		{
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x001D22F5 File Offset: 0x001D04F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitInfo(RogueMagicUnitInfo other) : this()
		{
			this.magicUnitId_ = other.magicUnitId_;
			this.magicUnitLevel_ = other.magicUnitLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x001D2326 File Offset: 0x001D0526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitInfo Clone()
		{
			return new RogueMagicUnitInfo(this);
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600AD58 RID: 44376 RVA: 0x001D232E File Offset: 0x001D052E
		// (set) Token: 0x0600AD59 RID: 44377 RVA: 0x001D2336 File Offset: 0x001D0536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitId
		{
			get
			{
				return this.magicUnitId_;
			}
			set
			{
				this.magicUnitId_ = value;
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600AD5A RID: 44378 RVA: 0x001D233F File Offset: 0x001D053F
		// (set) Token: 0x0600AD5B RID: 44379 RVA: 0x001D2347 File Offset: 0x001D0547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitLevel
		{
			get
			{
				return this.magicUnitLevel_;
			}
			set
			{
				this.magicUnitLevel_ = value;
			}
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x001D2350 File Offset: 0x001D0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitInfo);
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x001D235E File Offset: 0x001D055E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitInfo other)
		{
			return other != null && (other == this || (this.MagicUnitId == other.MagicUnitId && this.MagicUnitLevel == other.MagicUnitLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x001D239C File Offset: 0x001D059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MagicUnitId != 0U)
			{
				num ^= this.MagicUnitId.GetHashCode();
			}
			if (this.MagicUnitLevel != 0U)
			{
				num ^= this.MagicUnitLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x001D23F4 File Offset: 0x001D05F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x001D23FC File Offset: 0x001D05FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x001D2408 File Offset: 0x001D0608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MagicUnitId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MagicUnitId);
			}
			if (this.MagicUnitLevel != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MagicUnitLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x001D2464 File Offset: 0x001D0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MagicUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitId);
			}
			if (this.MagicUnitLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x001D24BC File Offset: 0x001D06BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MagicUnitId != 0U)
			{
				this.MagicUnitId = other.MagicUnitId;
			}
			if (other.MagicUnitLevel != 0U)
			{
				this.MagicUnitLevel = other.MagicUnitLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x001D250C File Offset: 0x001D070C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x001D2518 File Offset: 0x001D0718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MagicUnitLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.MagicUnitId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004694 RID: 18068
		private static readonly MessageParser<RogueMagicUnitInfo> _parser = new MessageParser<RogueMagicUnitInfo>(() => new RogueMagicUnitInfo());

		// Token: 0x04004695 RID: 18069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004696 RID: 18070
		public const int MagicUnitIdFieldNumber = 7;

		// Token: 0x04004697 RID: 18071
		private uint magicUnitId_;

		// Token: 0x04004698 RID: 18072
		public const int MagicUnitLevelFieldNumber = 9;

		// Token: 0x04004699 RID: 18073
		private uint magicUnitLevel_;
	}
}
