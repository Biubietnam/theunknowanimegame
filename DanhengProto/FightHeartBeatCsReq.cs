using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000537 RID: 1335
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightHeartBeatCsReq : IMessage<FightHeartBeatCsReq>, IMessage, IEquatable<FightHeartBeatCsReq>, IDeepCloneable<FightHeartBeatCsReq>, IBufferMessage
	{
		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x000A3C24 File Offset: 0x000A1E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightHeartBeatCsReq> Parser
		{
			get
			{
				return FightHeartBeatCsReq._parser;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x000A3C2B File Offset: 0x000A1E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightHeartBeatCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x000A3C3D File Offset: 0x000A1E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightHeartBeatCsReq.Descriptor;
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x000A3C44 File Offset: 0x000A1E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatCsReq()
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x000A3C4C File Offset: 0x000A1E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatCsReq(FightHeartBeatCsReq other) : this()
		{
			this.clientTimeMs_ = other.clientTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x000A3C71 File Offset: 0x000A1E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightHeartBeatCsReq Clone()
		{
			return new FightHeartBeatCsReq(this);
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x000A3C79 File Offset: 0x000A1E79
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x000A3C81 File Offset: 0x000A1E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ClientTimeMs
		{
			get
			{
				return this.clientTimeMs_;
			}
			set
			{
				this.clientTimeMs_ = value;
			}
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x000A3C8A File Offset: 0x000A1E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightHeartBeatCsReq);
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x000A3C98 File Offset: 0x000A1E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightHeartBeatCsReq other)
		{
			return other != null && (other == this || (this.ClientTimeMs == other.ClientTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x000A3CC8 File Offset: 0x000A1EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTimeMs != 0UL)
			{
				num ^= this.ClientTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x000A3D07 File Offset: 0x000A1F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x000A3D0F File Offset: 0x000A1F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000A3D18 File Offset: 0x000A1F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientTimeMs != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.ClientTimeMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000A3D4C File Offset: 0x000A1F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000A3D8A File Offset: 0x000A1F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightHeartBeatCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTimeMs != 0UL)
			{
				this.ClientTimeMs = other.ClientTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x000A3DBB File Offset: 0x000A1FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x000A3DC4 File Offset: 0x000A1FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ClientTimeMs = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040017FA RID: 6138
		private static readonly MessageParser<FightHeartBeatCsReq> _parser = new MessageParser<FightHeartBeatCsReq>(() => new FightHeartBeatCsReq());

		// Token: 0x040017FB RID: 6139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017FC RID: 6140
		public const int ClientTimeMsFieldNumber = 14;

		// Token: 0x040017FD RID: 6141
		private ulong clientTimeMs_;
	}
}
