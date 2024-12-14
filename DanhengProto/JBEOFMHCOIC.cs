using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000953 RID: 2387
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JBEOFMHCOIC : IMessage<JBEOFMHCOIC>, IMessage, IEquatable<JBEOFMHCOIC>, IDeepCloneable<JBEOFMHCOIC>, IBufferMessage
	{
		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x0011C4B4 File Offset: 0x0011A6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JBEOFMHCOIC> Parser
		{
			get
			{
				return JBEOFMHCOIC._parser;
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06006A93 RID: 27283 RVA: 0x0011C4BB File Offset: 0x0011A6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JBEOFMHCOICReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x0011C4CD File Offset: 0x0011A6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JBEOFMHCOIC.Descriptor;
			}
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x0011C4D4 File Offset: 0x0011A6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBEOFMHCOIC()
		{
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x0011C4DC File Offset: 0x0011A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBEOFMHCOIC(JBEOFMHCOIC other) : this()
		{
			this.eBIIGLJKAJO_ = other.eBIIGLJKAJO_;
			this.gEEJPHNHHOD_ = other.gEEJPHNHHOD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x0011C50D File Offset: 0x0011A70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBEOFMHCOIC Clone()
		{
			return new JBEOFMHCOIC(this);
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x0011C515 File Offset: 0x0011A715
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x0011C51D File Offset: 0x0011A71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EBIIGLJKAJO
		{
			get
			{
				return this.eBIIGLJKAJO_;
			}
			set
			{
				this.eBIIGLJKAJO_ = value;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x0011C526 File Offset: 0x0011A726
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x0011C52E File Offset: 0x0011A72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GEEJPHNHHOD
		{
			get
			{
				return this.gEEJPHNHHOD_;
			}
			set
			{
				this.gEEJPHNHHOD_ = value;
			}
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x0011C537 File Offset: 0x0011A737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JBEOFMHCOIC);
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x0011C545 File Offset: 0x0011A745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JBEOFMHCOIC other)
		{
			return other != null && (other == this || (this.EBIIGLJKAJO == other.EBIIGLJKAJO && this.GEEJPHNHHOD == other.GEEJPHNHHOD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x0011C584 File Offset: 0x0011A784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EBIIGLJKAJO != 0U)
			{
				num ^= this.EBIIGLJKAJO.GetHashCode();
			}
			if (this.GEEJPHNHHOD != 0U)
			{
				num ^= this.GEEJPHNHHOD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x0011C5DC File Offset: 0x0011A7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x0011C5E4 File Offset: 0x0011A7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0011C5F0 File Offset: 0x0011A7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GEEJPHNHHOD != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GEEJPHNHHOD);
			}
			if (this.EBIIGLJKAJO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EBIIGLJKAJO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x0011C648 File Offset: 0x0011A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EBIIGLJKAJO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EBIIGLJKAJO);
			}
			if (this.GEEJPHNHHOD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GEEJPHNHHOD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x0011C6A0 File Offset: 0x0011A8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JBEOFMHCOIC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EBIIGLJKAJO != 0U)
			{
				this.EBIIGLJKAJO = other.EBIIGLJKAJO;
			}
			if (other.GEEJPHNHHOD != 0U)
			{
				this.GEEJPHNHHOD = other.GEEJPHNHHOD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x0011C6F0 File Offset: 0x0011A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x0011C6FC File Offset: 0x0011A8FC
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
						this.EBIIGLJKAJO = input.ReadUInt32();
					}
				}
				else
				{
					this.GEEJPHNHHOD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040028CE RID: 10446
		private static readonly MessageParser<JBEOFMHCOIC> _parser = new MessageParser<JBEOFMHCOIC>(() => new JBEOFMHCOIC());

		// Token: 0x040028CF RID: 10447
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D0 RID: 10448
		public const int EBIIGLJKAJOFieldNumber = 14;

		// Token: 0x040028D1 RID: 10449
		private uint eBIIGLJKAJO_;

		// Token: 0x040028D2 RID: 10450
		public const int GEEJPHNHHODFieldNumber = 1;

		// Token: 0x040028D3 RID: 10451
		private uint gEEJPHNHHOD_;
	}
}
