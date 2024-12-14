using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A6F RID: 2671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MACIKPDHMMH : IMessage<MACIKPDHMMH>, IMessage, IEquatable<MACIKPDHMMH>, IDeepCloneable<MACIKPDHMMH>, IBufferMessage
	{
		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600766F RID: 30319 RVA: 0x0013A4FC File Offset: 0x001386FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MACIKPDHMMH> Parser
		{
			get
			{
				return MACIKPDHMMH._parser;
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x0013A503 File Offset: 0x00138703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MACIKPDHMMHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06007671 RID: 30321 RVA: 0x0013A515 File Offset: 0x00138715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MACIKPDHMMH.Descriptor;
			}
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x0013A51C File Offset: 0x0013871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MACIKPDHMMH()
		{
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x0013A524 File Offset: 0x00138724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MACIKPDHMMH(MACIKPDHMMH other) : this()
		{
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this.isMeet_ = other.isMeet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x0013A555 File Offset: 0x00138755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MACIKPDHMMH Clone()
		{
			return new MACIKPDHMMH(this);
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x0013A55D File Offset: 0x0013875D
		// (set) Token: 0x06007676 RID: 30326 RVA: 0x0013A565 File Offset: 0x00138765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06007677 RID: 30327 RVA: 0x0013A56E File Offset: 0x0013876E
		// (set) Token: 0x06007678 RID: 30328 RVA: 0x0013A576 File Offset: 0x00138776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMeet
		{
			get
			{
				return this.isMeet_;
			}
			set
			{
				this.isMeet_ = value;
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x0013A57F File Offset: 0x0013877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MACIKPDHMMH);
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x0013A58D File Offset: 0x0013878D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MACIKPDHMMH other)
		{
			return other != null && (other == this || (this.DJLKCHKMNMI == other.DJLKCHKMNMI && this.IsMeet == other.IsMeet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x0013A5CC File Offset: 0x001387CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this.IsMeet)
			{
				num ^= this.IsMeet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x0013A624 File Offset: 0x00138824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x0013A62C File Offset: 0x0013882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x0013A638 File Offset: 0x00138838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMeet)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsMeet);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x0013A690 File Offset: 0x00138890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this.IsMeet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x0013A6DC File Offset: 0x001388DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MACIKPDHMMH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			if (other.IsMeet)
			{
				this.IsMeet = other.IsMeet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x0013A72C File Offset: 0x0013892C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x0013A738 File Offset: 0x00138938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DJLKCHKMNMI = input.ReadUInt32();
					}
				}
				else
				{
					this.IsMeet = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D83 RID: 11651
		private static readonly MessageParser<MACIKPDHMMH> _parser = new MessageParser<MACIKPDHMMH>(() => new MACIKPDHMMH());

		// Token: 0x04002D84 RID: 11652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D85 RID: 11653
		public const int DJLKCHKMNMIFieldNumber = 14;

		// Token: 0x04002D86 RID: 11654
		private uint dJLKCHKMNMI_;

		// Token: 0x04002D87 RID: 11655
		public const int IsMeetFieldNumber = 1;

		// Token: 0x04002D88 RID: 11656
		private bool isMeet_;
	}
}
