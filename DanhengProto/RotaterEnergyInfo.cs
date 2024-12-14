using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001045 RID: 4165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RotaterEnergyInfo : IMessage<RotaterEnergyInfo>, IMessage, IEquatable<RotaterEnergyInfo>, IDeepCloneable<RotaterEnergyInfo>, IBufferMessage
	{
		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600B94A RID: 47434 RVA: 0x001F17A0 File Offset: 0x001EF9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RotaterEnergyInfo> Parser
		{
			get
			{
				return RotaterEnergyInfo._parser;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600B94B RID: 47435 RVA: 0x001F17A7 File Offset: 0x001EF9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RotaterEnergyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600B94C RID: 47436 RVA: 0x001F17B9 File Offset: 0x001EF9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotaterEnergyInfo.Descriptor;
			}
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x001F17C0 File Offset: 0x001EF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo()
		{
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x001F17C8 File Offset: 0x001EF9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo(RotaterEnergyInfo other) : this()
		{
			this.curNum_ = other.curNum_;
			this.maxNum_ = other.maxNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x001F17F9 File Offset: 0x001EF9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo Clone()
		{
			return new RotaterEnergyInfo(this);
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600B950 RID: 47440 RVA: 0x001F1801 File Offset: 0x001EFA01
		// (set) Token: 0x0600B951 RID: 47441 RVA: 0x001F1809 File Offset: 0x001EFA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurNum
		{
			get
			{
				return this.curNum_;
			}
			set
			{
				this.curNum_ = value;
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x001F1812 File Offset: 0x001EFA12
		// (set) Token: 0x0600B953 RID: 47443 RVA: 0x001F181A File Offset: 0x001EFA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxNum
		{
			get
			{
				return this.maxNum_;
			}
			set
			{
				this.maxNum_ = value;
			}
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x001F1823 File Offset: 0x001EFA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotaterEnergyInfo);
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x001F1831 File Offset: 0x001EFA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotaterEnergyInfo other)
		{
			return other != null && (other == this || (this.CurNum == other.CurNum && this.MaxNum == other.MaxNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x001F1870 File Offset: 0x001EFA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurNum != 0U)
			{
				num ^= this.CurNum.GetHashCode();
			}
			if (this.MaxNum != 0U)
			{
				num ^= this.MaxNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x001F18C8 File Offset: 0x001EFAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x001F18D0 File Offset: 0x001EFAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x001F18DC File Offset: 0x001EFADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurNum != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurNum);
			}
			if (this.MaxNum != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MaxNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x001F1938 File Offset: 0x001EFB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurNum);
			}
			if (this.MaxNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B95B RID: 47451 RVA: 0x001F1990 File Offset: 0x001EFB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotaterEnergyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurNum != 0U)
			{
				this.CurNum = other.CurNum;
			}
			if (other.MaxNum != 0U)
			{
				this.MaxNum = other.MaxNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x001F19E0 File Offset: 0x001EFBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x001F19EC File Offset: 0x001EFBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxNum = input.ReadUInt32();
					}
				}
				else
				{
					this.CurNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004B0D RID: 19213
		private static readonly MessageParser<RotaterEnergyInfo> _parser = new MessageParser<RotaterEnergyInfo>(() => new RotaterEnergyInfo());

		// Token: 0x04004B0E RID: 19214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B0F RID: 19215
		public const int CurNumFieldNumber = 3;

		// Token: 0x04004B10 RID: 19216
		private uint curNum_;

		// Token: 0x04004B11 RID: 19217
		public const int MaxNumFieldNumber = 6;

		// Token: 0x04004B12 RID: 19218
		private uint maxNum_;
	}
}
