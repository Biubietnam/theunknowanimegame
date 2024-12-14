using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ABD RID: 2749
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MechanismBarInfo : IMessage<MechanismBarInfo>, IMessage, IEquatable<MechanismBarInfo>, IDeepCloneable<MechanismBarInfo>, IBufferMessage
	{
		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x00142F34 File Offset: 0x00141134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MechanismBarInfo> Parser
		{
			get
			{
				return MechanismBarInfo._parser;
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x00142F3B File Offset: 0x0014113B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MechanismBarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x00142F4D File Offset: 0x0014114D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MechanismBarInfo.Descriptor;
			}
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00142F54 File Offset: 0x00141154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MechanismBarInfo()
		{
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00142F5C File Offset: 0x0014115C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MechanismBarInfo(MechanismBarInfo other) : this()
		{
			this.oMJJJNANJIP_ = other.oMJJJNANJIP_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00142F8D File Offset: 0x0014118D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MechanismBarInfo Clone()
		{
			return new MechanismBarInfo(this);
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x00142F95 File Offset: 0x00141195
		// (set) Token: 0x060079F0 RID: 31216 RVA: 0x00142F9D File Offset: 0x0014119D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OMJJJNANJIP
		{
			get
			{
				return this.oMJJJNANJIP_;
			}
			set
			{
				this.oMJJJNANJIP_ = value;
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x00142FA6 File Offset: 0x001411A6
		// (set) Token: 0x060079F2 RID: 31218 RVA: 0x00142FAE File Offset: 0x001411AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00142FB7 File Offset: 0x001411B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MechanismBarInfo);
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x00142FC5 File Offset: 0x001411C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MechanismBarInfo other)
		{
			return other != null && (other == this || (this.OMJJJNANJIP == other.OMJJJNANJIP && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x00143004 File Offset: 0x00141204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OMJJJNANJIP != 0U)
			{
				num ^= this.OMJJJNANJIP.GetHashCode();
			}
			if (this.Value != 0U)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x0014305C File Offset: 0x0014125C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x00143064 File Offset: 0x00141264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00143070 File Offset: 0x00141270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Value != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Value);
			}
			if (this.OMJJJNANJIP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.OMJJJNANJIP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x001430CC File Offset: 0x001412CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OMJJJNANJIP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OMJJJNANJIP);
			}
			if (this.Value != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x00143124 File Offset: 0x00141324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MechanismBarInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OMJJJNANJIP != 0U)
			{
				this.OMJJJNANJIP = other.OMJJJNANJIP;
			}
			if (other.Value != 0U)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00143174 File Offset: 0x00141374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x00143180 File Offset: 0x00141380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OMJJJNANJIP = input.ReadUInt32();
					}
				}
				else
				{
					this.Value = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EC6 RID: 11974
		private static readonly MessageParser<MechanismBarInfo> _parser = new MessageParser<MechanismBarInfo>(() => new MechanismBarInfo());

		// Token: 0x04002EC7 RID: 11975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EC8 RID: 11976
		public const int OMJJJNANJIPFieldNumber = 14;

		// Token: 0x04002EC9 RID: 11977
		private uint oMJJJNANJIP_;

		// Token: 0x04002ECA RID: 11978
		public const int ValueFieldNumber = 2;

		// Token: 0x04002ECB RID: 11979
		private uint value_;
	}
}
