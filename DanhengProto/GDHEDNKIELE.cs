using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005ED RID: 1517
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GDHEDNKIELE : IMessage<GDHEDNKIELE>, IMessage, IEquatable<GDHEDNKIELE>, IDeepCloneable<GDHEDNKIELE>, IBufferMessage
	{
		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x000BB278 File Offset: 0x000B9478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GDHEDNKIELE> Parser
		{
			get
			{
				return GDHEDNKIELE._parser;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x000BB27F File Offset: 0x000B947F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GDHEDNKIELEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x000BB291 File Offset: 0x000B9491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GDHEDNKIELE.Descriptor;
			}
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x000BB298 File Offset: 0x000B9498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDHEDNKIELE()
		{
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000BB2A0 File Offset: 0x000B94A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDHEDNKIELE(GDHEDNKIELE other) : this()
		{
			this.dEAOJPFLHJG_ = other.dEAOJPFLHJG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000BB2C5 File Offset: 0x000B94C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDHEDNKIELE Clone()
		{
			return new GDHEDNKIELE(this);
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x000BB2CD File Offset: 0x000B94CD
		// (set) Token: 0x06004427 RID: 17447 RVA: 0x000BB2D5 File Offset: 0x000B94D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DEAOJPFLHJG
		{
			get
			{
				return this.dEAOJPFLHJG_;
			}
			set
			{
				this.dEAOJPFLHJG_ = value;
			}
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x000BB2DE File Offset: 0x000B94DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GDHEDNKIELE);
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x000BB2EC File Offset: 0x000B94EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GDHEDNKIELE other)
		{
			return other != null && (other == this || (this.DEAOJPFLHJG == other.DEAOJPFLHJG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x000BB31C File Offset: 0x000B951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DEAOJPFLHJG != 0U)
			{
				num ^= this.DEAOJPFLHJG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x000BB35B File Offset: 0x000B955B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x000BB363 File Offset: 0x000B9563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000BB36C File Offset: 0x000B956C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DEAOJPFLHJG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.DEAOJPFLHJG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x000BB3A0 File Offset: 0x000B95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DEAOJPFLHJG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DEAOJPFLHJG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x000BB3DE File Offset: 0x000B95DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GDHEDNKIELE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DEAOJPFLHJG != 0U)
			{
				this.DEAOJPFLHJG = other.DEAOJPFLHJG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000BB40F File Offset: 0x000B960F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000BB418 File Offset: 0x000B9618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DEAOJPFLHJG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001B4C RID: 6988
		private static readonly MessageParser<GDHEDNKIELE> _parser = new MessageParser<GDHEDNKIELE>(() => new GDHEDNKIELE());

		// Token: 0x04001B4D RID: 6989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B4E RID: 6990
		public const int DEAOJPFLHJGFieldNumber = 1;

		// Token: 0x04001B4F RID: 6991
		private uint dEAOJPFLHJG_;
	}
}
