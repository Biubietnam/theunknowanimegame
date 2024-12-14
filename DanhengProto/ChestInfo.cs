using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002BD RID: 701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChestInfo : IMessage<ChestInfo>, IMessage, IEquatable<ChestInfo>, IDeepCloneable<ChestInfo>, IBufferMessage
	{
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00059021 File Offset: 0x00057221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChestInfo> Parser
		{
			get
			{
				return ChestInfo._parser;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00059028 File Offset: 0x00057228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChestInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0005903A File Offset: 0x0005723A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChestInfo.Descriptor;
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00059041 File Offset: 0x00057241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChestInfo()
		{
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00059049 File Offset: 0x00057249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChestInfo(ChestInfo other) : this()
		{
			this.chestType_ = other.chestType_;
			this.openedNum_ = other.openedNum_;
			this.existNum_ = other.existNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00059086 File Offset: 0x00057286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChestInfo Clone()
		{
			return new ChestInfo(this);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0005908E File Offset: 0x0005728E
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00059096 File Offset: 0x00057296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChestType ChestType
		{
			get
			{
				return this.chestType_;
			}
			set
			{
				this.chestType_ = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0005909F File Offset: 0x0005729F
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x000590A7 File Offset: 0x000572A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OpenedNum
		{
			get
			{
				return this.openedNum_;
			}
			set
			{
				this.openedNum_ = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x000590B0 File Offset: 0x000572B0
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x000590B8 File Offset: 0x000572B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExistNum
		{
			get
			{
				return this.existNum_;
			}
			set
			{
				this.existNum_ = value;
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000590C1 File Offset: 0x000572C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChestInfo);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x000590D0 File Offset: 0x000572D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChestInfo other)
		{
			return other != null && (other == this || (this.ChestType == other.ChestType && this.OpenedNum == other.OpenedNum && this.ExistNum == other.ExistNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0005912C File Offset: 0x0005732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChestType != ChestType.MapInfoChestTypeNone)
			{
				num ^= this.ChestType.GetHashCode();
			}
			if (this.OpenedNum != 0U)
			{
				num ^= this.OpenedNum.GetHashCode();
			}
			if (this.ExistNum != 0U)
			{
				num ^= this.ExistNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x000591A3 File Offset: 0x000573A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000591AB File Offset: 0x000573AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000591B4 File Offset: 0x000573B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExistNum != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ExistNum);
			}
			if (this.OpenedNum != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OpenedNum);
			}
			if (this.ChestType != ChestType.MapInfoChestTypeNone)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ChestType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0005922C File Offset: 0x0005742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChestType != ChestType.MapInfoChestTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChestType);
			}
			if (this.OpenedNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpenedNum);
			}
			if (this.ExistNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExistNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0005929C File Offset: 0x0005749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChestType != ChestType.MapInfoChestTypeNone)
			{
				this.ChestType = other.ChestType;
			}
			if (other.OpenedNum != 0U)
			{
				this.OpenedNum = other.OpenedNum;
			}
			if (other.ExistNum != 0U)
			{
				this.ExistNum = other.ExistNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00059300 File Offset: 0x00057500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0005930C File Offset: 0x0005750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChestType = (ChestType)input.ReadEnum();
						}
					}
					else
					{
						this.OpenedNum = input.ReadUInt32();
					}
				}
				else
				{
					this.ExistNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000CEF RID: 3311
		private static readonly MessageParser<ChestInfo> _parser = new MessageParser<ChestInfo>(() => new ChestInfo());

		// Token: 0x04000CF0 RID: 3312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CF1 RID: 3313
		public const int ChestTypeFieldNumber = 11;

		// Token: 0x04000CF2 RID: 3314
		private ChestType chestType_;

		// Token: 0x04000CF3 RID: 3315
		public const int OpenedNumFieldNumber = 10;

		// Token: 0x04000CF4 RID: 3316
		private uint openedNum_;

		// Token: 0x04000CF5 RID: 3317
		public const int ExistNumFieldNumber = 4;

		// Token: 0x04000CF6 RID: 3318
		private uint existNum_;
	}
}
