using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA1 RID: 3233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PJAHEBJMLGH : IMessage<PJAHEBJMLGH>, IMessage, IEquatable<PJAHEBJMLGH>, IDeepCloneable<PJAHEBJMLGH>, IBufferMessage
	{
		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x0017BD0C File Offset: 0x00179F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PJAHEBJMLGH> Parser
		{
			get
			{
				return PJAHEBJMLGH._parser;
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x06008FC2 RID: 36802 RVA: 0x0017BD13 File Offset: 0x00179F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PJAHEBJMLGHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x0017BD25 File Offset: 0x00179F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PJAHEBJMLGH.Descriptor;
			}
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0017BD2C File Offset: 0x00179F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PJAHEBJMLGH()
		{
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0017BD34 File Offset: 0x00179F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PJAHEBJMLGH(PJAHEBJMLGH other) : this()
		{
			this.star_ = other.star_;
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0017BD71 File Offset: 0x00179F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PJAHEBJMLGH Clone()
		{
			return new PJAHEBJMLGH(this);
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x0017BD79 File Offset: 0x00179F79
		// (set) Token: 0x06008FC8 RID: 36808 RVA: 0x0017BD81 File Offset: 0x00179F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x0017BD8A File Offset: 0x00179F8A
		// (set) Token: 0x06008FCA RID: 36810 RVA: 0x0017BD92 File Offset: 0x00179F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x0017BD9B File Offset: 0x00179F9B
		// (set) Token: 0x06008FCC RID: 36812 RVA: 0x0017BDA3 File Offset: 0x00179FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x0017BDAC File Offset: 0x00179FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PJAHEBJMLGH);
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x0017BDBC File Offset: 0x00179FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PJAHEBJMLGH other)
		{
			return other != null && (other == this || (this.Star == other.Star && this.AHFNGPLDAII == other.AHFNGPLDAII && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x0017BE18 File Offset: 0x0017A018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0017BE89 File Offset: 0x0017A089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x0017BE91 File Offset: 0x0017A091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x0017BE9C File Offset: 0x0017A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GroupId);
			}
			if (this.Star != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Star);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x0017BF14 File Offset: 0x0017A114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0017BF84 File Offset: 0x0017A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PJAHEBJMLGH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x0017BFE8 File Offset: 0x0017A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0017BFF4 File Offset: 0x0017A1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Star = input.ReadUInt32();
						}
					}
					else
					{
						this.GroupId = input.ReadUInt32();
					}
				}
				else
				{
					this.AHFNGPLDAII = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003735 RID: 14133
		private static readonly MessageParser<PJAHEBJMLGH> _parser = new MessageParser<PJAHEBJMLGH>(() => new PJAHEBJMLGH());

		// Token: 0x04003736 RID: 14134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003737 RID: 14135
		public const int StarFieldNumber = 15;

		// Token: 0x04003738 RID: 14136
		private uint star_;

		// Token: 0x04003739 RID: 14137
		public const int AHFNGPLDAIIFieldNumber = 11;

		// Token: 0x0400373A RID: 14138
		private uint aHFNGPLDAII_;

		// Token: 0x0400373B RID: 14139
		public const int GroupIdFieldNumber = 13;

		// Token: 0x0400373C RID: 14140
		private uint groupId_;
	}
}
