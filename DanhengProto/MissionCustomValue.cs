using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADB RID: 2779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionCustomValue : IMessage<MissionCustomValue>, IMessage, IEquatable<MissionCustomValue>, IDeepCloneable<MissionCustomValue>, IBufferMessage
	{
		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x00145E18 File Offset: 0x00144018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionCustomValue> Parser
		{
			get
			{
				return MissionCustomValue._parser;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x00145E1F File Offset: 0x0014401F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionCustomValueReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06007B1D RID: 31517 RVA: 0x00145E31 File Offset: 0x00144031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionCustomValue.Descriptor;
			}
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x00145E38 File Offset: 0x00144038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValue()
		{
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x00145E40 File Offset: 0x00144040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValue(MissionCustomValue other) : this()
		{
			this.index_ = other.index_;
			this.customValue_ = other.customValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x00145E71 File Offset: 0x00144071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValue Clone()
		{
			return new MissionCustomValue(this);
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06007B21 RID: 31521 RVA: 0x00145E79 File Offset: 0x00144079
		// (set) Token: 0x06007B22 RID: 31522 RVA: 0x00145E81 File Offset: 0x00144081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x00145E8A File Offset: 0x0014408A
		// (set) Token: 0x06007B24 RID: 31524 RVA: 0x00145E92 File Offset: 0x00144092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CustomValue
		{
			get
			{
				return this.customValue_;
			}
			set
			{
				this.customValue_ = value;
			}
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x00145E9B File Offset: 0x0014409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionCustomValue);
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00145EA9 File Offset: 0x001440A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionCustomValue other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.CustomValue == other.CustomValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x00145EE8 File Offset: 0x001440E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.CustomValue != 0U)
			{
				num ^= this.CustomValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x00145F40 File Offset: 0x00144140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00145F48 File Offset: 0x00144148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x00145F54 File Offset: 0x00144154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Index);
			}
			if (this.CustomValue != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CustomValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00145FB0 File Offset: 0x001441B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.CustomValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CustomValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x00146008 File Offset: 0x00144208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionCustomValue other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.CustomValue != 0U)
			{
				this.CustomValue = other.CustomValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x00146058 File Offset: 0x00144258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00146064 File Offset: 0x00144264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CustomValue = input.ReadUInt32();
					}
				}
				else
				{
					this.Index = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002F3A RID: 12090
		private static readonly MessageParser<MissionCustomValue> _parser = new MessageParser<MissionCustomValue>(() => new MissionCustomValue());

		// Token: 0x04002F3B RID: 12091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F3C RID: 12092
		public const int IndexFieldNumber = 10;

		// Token: 0x04002F3D RID: 12093
		private uint index_;

		// Token: 0x04002F3E RID: 12094
		public const int CustomValueFieldNumber = 12;

		// Token: 0x04002F3F RID: 12095
		private uint customValue_;
	}
}
