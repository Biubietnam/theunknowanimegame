using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003ED RID: 1005
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ECHKEPBCIOJ : IMessage<ECHKEPBCIOJ>, IMessage, IEquatable<ECHKEPBCIOJ>, IDeepCloneable<ECHKEPBCIOJ>, IBufferMessage
	{
		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x0007C0E8 File Offset: 0x0007A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ECHKEPBCIOJ> Parser
		{
			get
			{
				return ECHKEPBCIOJ._parser;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x0007C0EF File Offset: 0x0007A2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ECHKEPBCIOJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x0007C101 File Offset: 0x0007A301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ECHKEPBCIOJ.Descriptor;
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0007C108 File Offset: 0x0007A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHKEPBCIOJ()
		{
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0007C110 File Offset: 0x0007A310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHKEPBCIOJ(ECHKEPBCIOJ other) : this()
		{
			this.gPCFHFKHMID_ = other.gPCFHFKHMID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0007C135 File Offset: 0x0007A335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHKEPBCIOJ Clone()
		{
			return new ECHKEPBCIOJ(this);
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x0007C13D File Offset: 0x0007A33D
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x0007C145 File Offset: 0x0007A345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPCFHFKHMID
		{
			get
			{
				return this.gPCFHFKHMID_;
			}
			set
			{
				this.gPCFHFKHMID_ = value;
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0007C14E File Offset: 0x0007A34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ECHKEPBCIOJ);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0007C15C File Offset: 0x0007A35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ECHKEPBCIOJ other)
		{
			return other != null && (other == this || (this.GPCFHFKHMID == other.GPCFHFKHMID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0007C18C File Offset: 0x0007A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GPCFHFKHMID != 0U)
			{
				num ^= this.GPCFHFKHMID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0007C1CB File Offset: 0x0007A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0007C1D3 File Offset: 0x0007A3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x0007C1DC File Offset: 0x0007A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GPCFHFKHMID != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GPCFHFKHMID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0007C210 File Offset: 0x0007A410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GPCFHFKHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPCFHFKHMID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0007C24E File Offset: 0x0007A44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ECHKEPBCIOJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GPCFHFKHMID != 0U)
			{
				this.GPCFHFKHMID = other.GPCFHFKHMID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0007C27F File Offset: 0x0007A47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0007C288 File Offset: 0x0007A488
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
					this.GPCFHFKHMID = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400120D RID: 4621
		private static readonly MessageParser<ECHKEPBCIOJ> _parser = new MessageParser<ECHKEPBCIOJ>(() => new ECHKEPBCIOJ());

		// Token: 0x0400120E RID: 4622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400120F RID: 4623
		public const int GPCFHFKHMIDFieldNumber = 6;

		// Token: 0x04001210 RID: 4624
		private uint gPCFHFKHMID_;
	}
}
