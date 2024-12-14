using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A1 RID: 1185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildCoinNotify : IMessage<EvolveBuildCoinNotify>, IMessage, IEquatable<EvolveBuildCoinNotify>, IDeepCloneable<EvolveBuildCoinNotify>, IBufferMessage
	{
		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x00091E48 File Offset: 0x00090048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildCoinNotify> Parser
		{
			get
			{
				return EvolveBuildCoinNotify._parser;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00091E4F File Offset: 0x0009004F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildCoinNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x00091E61 File Offset: 0x00090061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildCoinNotify.Descriptor;
			}
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00091E68 File Offset: 0x00090068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildCoinNotify()
		{
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00091E70 File Offset: 0x00090070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildCoinNotify(EvolveBuildCoinNotify other) : this()
		{
			this.itemValue_ = other.itemValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00091E95 File Offset: 0x00090095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildCoinNotify Clone()
		{
			return new EvolveBuildCoinNotify(this);
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x00091E9D File Offset: 0x0009009D
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x00091EA5 File Offset: 0x000900A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00091EAE File Offset: 0x000900AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildCoinNotify);
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00091EBC File Offset: 0x000900BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildCoinNotify other)
		{
			return other != null && (other == this || (this.ItemValue == other.ItemValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00091EEC File Offset: 0x000900EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00091F2B File Offset: 0x0009012B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00091F33 File Offset: 0x00090133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00091F3C File Offset: 0x0009013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00091F70 File Offset: 0x00090170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00091FAE File Offset: 0x000901AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildCoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00091FDF File Offset: 0x000901DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00091FE8 File Offset: 0x000901E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemValue = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001523 RID: 5411
		private static readonly MessageParser<EvolveBuildCoinNotify> _parser = new MessageParser<EvolveBuildCoinNotify>(() => new EvolveBuildCoinNotify());

		// Token: 0x04001524 RID: 5412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001525 RID: 5413
		public const int ItemValueFieldNumber = 14;

		// Token: 0x04001526 RID: 5414
		private uint itemValue_;
	}
}
