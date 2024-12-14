using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200084D RID: 2125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetWaypointCsReq : IMessage<GetWaypointCsReq>, IMessage, IEquatable<GetWaypointCsReq>, IDeepCloneable<GetWaypointCsReq>, IBufferMessage
	{
		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x000FA170 File Offset: 0x000F8370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetWaypointCsReq> Parser
		{
			get
			{
				return GetWaypointCsReq._parser;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005E7A RID: 24186 RVA: 0x000FA177 File Offset: 0x000F8377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetWaypointCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x000FA189 File Offset: 0x000F8389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWaypointCsReq.Descriptor;
			}
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x000FA190 File Offset: 0x000F8390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointCsReq()
		{
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x000FA198 File Offset: 0x000F8398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointCsReq(GetWaypointCsReq other) : this()
		{
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x000FA1BD File Offset: 0x000F83BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWaypointCsReq Clone()
		{
			return new GetWaypointCsReq(this);
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x000FA1C5 File Offset: 0x000F83C5
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x000FA1CD File Offset: 0x000F83CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIGPMMBDEJD
		{
			get
			{
				return this.cIGPMMBDEJD_;
			}
			set
			{
				this.cIGPMMBDEJD_ = value;
			}
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x000FA1D6 File Offset: 0x000F83D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWaypointCsReq);
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x000FA1E4 File Offset: 0x000F83E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetWaypointCsReq other)
		{
			return other != null && (other == this || (this.CIGPMMBDEJD == other.CIGPMMBDEJD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x000FA214 File Offset: 0x000F8414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x000FA253 File Offset: 0x000F8453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x000FA25B File Offset: 0x000F845B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x000FA264 File Offset: 0x000F8464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x000FA298 File Offset: 0x000F8498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x000FA2D6 File Offset: 0x000F84D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetWaypointCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x000FA307 File Offset: 0x000F8507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x000FA310 File Offset: 0x000F8510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CIGPMMBDEJD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002462 RID: 9314
		private static readonly MessageParser<GetWaypointCsReq> _parser = new MessageParser<GetWaypointCsReq>(() => new GetWaypointCsReq());

		// Token: 0x04002463 RID: 9315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002464 RID: 9316
		public const int CIGPMMBDEJDFieldNumber = 8;

		// Token: 0x04002465 RID: 9317
		private uint cIGPMMBDEJD_;
	}
}
