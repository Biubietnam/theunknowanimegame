using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A7F RID: 2687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MAKKMBLOHHO : IMessage<MAKKMBLOHHO>, IMessage, IEquatable<MAKKMBLOHHO>, IDeepCloneable<MAKKMBLOHHO>, IBufferMessage
	{
		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600771B RID: 30491 RVA: 0x0013C110 File Offset: 0x0013A310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MAKKMBLOHHO> Parser
		{
			get
			{
				return MAKKMBLOHHO._parser;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600771C RID: 30492 RVA: 0x0013C117 File Offset: 0x0013A317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MAKKMBLOHHOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600771D RID: 30493 RVA: 0x0013C129 File Offset: 0x0013A329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MAKKMBLOHHO.Descriptor;
			}
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x0013C130 File Offset: 0x0013A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MAKKMBLOHHO()
		{
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x0013C138 File Offset: 0x0013A338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MAKKMBLOHHO(MAKKMBLOHHO other) : this()
		{
			this.eJLFAKJGOIJ_ = other.eJLFAKJGOIJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x0013C15D File Offset: 0x0013A35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MAKKMBLOHHO Clone()
		{
			return new MAKKMBLOHHO(this);
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06007721 RID: 30497 RVA: 0x0013C165 File Offset: 0x0013A365
		// (set) Token: 0x06007722 RID: 30498 RVA: 0x0013C16D File Offset: 0x0013A36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EJLFAKJGOIJ
		{
			get
			{
				return this.eJLFAKJGOIJ_;
			}
			set
			{
				this.eJLFAKJGOIJ_ = value;
			}
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x0013C176 File Offset: 0x0013A376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MAKKMBLOHHO);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x0013C184 File Offset: 0x0013A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MAKKMBLOHHO other)
		{
			return other != null && (other == this || (this.EJLFAKJGOIJ == other.EJLFAKJGOIJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x0013C1B4 File Offset: 0x0013A3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EJLFAKJGOIJ != 0U)
			{
				num ^= this.EJLFAKJGOIJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x0013C1F3 File Offset: 0x0013A3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x0013C1FB File Offset: 0x0013A3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x0013C204 File Offset: 0x0013A404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EJLFAKJGOIJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EJLFAKJGOIJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x0013C238 File Offset: 0x0013A438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EJLFAKJGOIJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EJLFAKJGOIJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x0013C276 File Offset: 0x0013A476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MAKKMBLOHHO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EJLFAKJGOIJ != 0U)
			{
				this.EJLFAKJGOIJ = other.EJLFAKJGOIJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x0013C2A7 File Offset: 0x0013A4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x0013C2B0 File Offset: 0x0013A4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EJLFAKJGOIJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DC3 RID: 11715
		private static readonly MessageParser<MAKKMBLOHHO> _parser = new MessageParser<MAKKMBLOHHO>(() => new MAKKMBLOHHO());

		// Token: 0x04002DC4 RID: 11716
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC5 RID: 11717
		public const int EJLFAKJGOIJFieldNumber = 6;

		// Token: 0x04002DC6 RID: 11718
		private uint eJLFAKJGOIJ_;
	}
}
