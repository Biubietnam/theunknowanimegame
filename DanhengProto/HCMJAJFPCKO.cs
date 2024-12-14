using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000893 RID: 2195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HCMJAJFPCKO : IMessage<HCMJAJFPCKO>, IMessage, IEquatable<HCMJAJFPCKO>, IDeepCloneable<HCMJAJFPCKO>, IBufferMessage
	{
		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x001067D0 File Offset: 0x001049D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HCMJAJFPCKO> Parser
		{
			get
			{
				return HCMJAJFPCKO._parser;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x001067D7 File Offset: 0x001049D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HCMJAJFPCKOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060061FE RID: 25086 RVA: 0x001067E9 File Offset: 0x001049E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HCMJAJFPCKO.Descriptor;
			}
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x001067F0 File Offset: 0x001049F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HCMJAJFPCKO()
		{
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x001067F8 File Offset: 0x001049F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HCMJAJFPCKO(HCMJAJFPCKO other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x00106829 File Offset: 0x00104A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HCMJAJFPCKO Clone()
		{
			return new HCMJAJFPCKO(this);
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06006202 RID: 25090 RVA: 0x00106831 File Offset: 0x00104A31
		// (set) Token: 0x06006203 RID: 25091 RVA: 0x00106839 File Offset: 0x00104A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06006204 RID: 25092 RVA: 0x00106842 File Offset: 0x00104A42
		// (set) Token: 0x06006205 RID: 25093 RVA: 0x0010684A File Offset: 0x00104A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x00106853 File Offset: 0x00104A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HCMJAJFPCKO);
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00106861 File Offset: 0x00104A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HCMJAJFPCKO other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x001068A0 File Offset: 0x00104AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x001068F8 File Offset: 0x00104AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x00106900 File Offset: 0x00104B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x0010690C File Offset: 0x00104B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Progress);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x00106968 File Offset: 0x00104B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x001069C0 File Offset: 0x00104BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HCMJAJFPCKO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x00106A10 File Offset: 0x00104C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00106A1C File Offset: 0x00104C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Progress = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040025B4 RID: 9652
		private static readonly MessageParser<HCMJAJFPCKO> _parser = new MessageParser<HCMJAJFPCKO>(() => new HCMJAJFPCKO());

		// Token: 0x040025B5 RID: 9653
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025B6 RID: 9654
		public const int IdFieldNumber = 13;

		// Token: 0x040025B7 RID: 9655
		private uint id_;

		// Token: 0x040025B8 RID: 9656
		public const int ProgressFieldNumber = 3;

		// Token: 0x040025B9 RID: 9657
		private uint progress_;
	}
}
