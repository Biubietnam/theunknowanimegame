using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F0F RID: 3855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterSelectResult : IMessage<RogueMagicScepterSelectResult>, IMessage, IEquatable<RogueMagicScepterSelectResult>, IDeepCloneable<RogueMagicScepterSelectResult>, IBufferMessage
	{
		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x001CF42B File Offset: 0x001CD62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterSelectResult> Parser
		{
			get
			{
				return RogueMagicScepterSelectResult._parser;
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x001CF432 File Offset: 0x001CD632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x001CF444 File Offset: 0x001CD644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterSelectResult.Descriptor;
			}
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x001CF44B File Offset: 0x001CD64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectResult()
		{
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x001CF454 File Offset: 0x001CD654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectResult(RogueMagicScepterSelectResult other) : this()
		{
			this.lPNCBNCJDIK_ = other.lPNCBNCJDIK_;
			this.selectScepter_ = ((other.selectScepter_ != null) ? other.selectScepter_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x001CF4A0 File Offset: 0x001CD6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectResult Clone()
		{
			return new RogueMagicScepterSelectResult(this);
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x001CF4A8 File Offset: 0x001CD6A8
		// (set) Token: 0x0600AC1E RID: 44062 RVA: 0x001CF4B0 File Offset: 0x001CD6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LPNCBNCJDIK
		{
			get
			{
				return this.lPNCBNCJDIK_;
			}
			set
			{
				this.lPNCBNCJDIK_ = value;
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600AC1F RID: 44063 RVA: 0x001CF4B9 File Offset: 0x001CD6B9
		// (set) Token: 0x0600AC20 RID: 44064 RVA: 0x001CF4C1 File Offset: 0x001CD6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter SelectScepter
		{
			get
			{
				return this.selectScepter_;
			}
			set
			{
				this.selectScepter_ = value;
			}
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x001CF4CA File Offset: 0x001CD6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterSelectResult);
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x001CF4D8 File Offset: 0x001CD6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterSelectResult other)
		{
			return other != null && (other == this || (this.LPNCBNCJDIK == other.LPNCBNCJDIK && object.Equals(this.SelectScepter, other.SelectScepter) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x001CF528 File Offset: 0x001CD728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LPNCBNCJDIK)
			{
				num ^= this.LPNCBNCJDIK.GetHashCode();
			}
			if (this.selectScepter_ != null)
			{
				num ^= this.SelectScepter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x001CF57D File Offset: 0x001CD77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x001CF585 File Offset: 0x001CD785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x001CF590 File Offset: 0x001CD790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selectScepter_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SelectScepter);
			}
			if (this.LPNCBNCJDIK)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.LPNCBNCJDIK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x001CF5EC File Offset: 0x001CD7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LPNCBNCJDIK)
			{
				num += 2;
			}
			if (this.selectScepter_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectScepter);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x001CF638 File Offset: 0x001CD838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LPNCBNCJDIK)
			{
				this.LPNCBNCJDIK = other.LPNCBNCJDIK;
			}
			if (other.selectScepter_ != null)
			{
				if (this.selectScepter_ == null)
				{
					this.SelectScepter = new RogueMagicScepter();
				}
				this.SelectScepter.MergeFrom(other.SelectScepter);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x001CF6A0 File Offset: 0x001CD8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x001CF6AC File Offset: 0x001CD8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LPNCBNCJDIK = input.ReadBool();
					}
				}
				else
				{
					if (this.selectScepter_ == null)
					{
						this.SelectScepter = new RogueMagicScepter();
					}
					input.ReadMessage(this.SelectScepter);
				}
			}
		}

		// Token: 0x0400462B RID: 17963
		private static readonly MessageParser<RogueMagicScepterSelectResult> _parser = new MessageParser<RogueMagicScepterSelectResult>(() => new RogueMagicScepterSelectResult());

		// Token: 0x0400462C RID: 17964
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400462D RID: 17965
		public const int LPNCBNCJDIKFieldNumber = 13;

		// Token: 0x0400462E RID: 17966
		private bool lPNCBNCJDIK_;

		// Token: 0x0400462F RID: 17967
		public const int SelectScepterFieldNumber = 2;

		// Token: 0x04004630 RID: 17968
		private RogueMagicScepter selectScepter_;
	}
}
