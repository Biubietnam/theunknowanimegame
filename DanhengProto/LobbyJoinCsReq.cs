using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A41 RID: 2625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyJoinCsReq : IMessage<LobbyJoinCsReq>, IMessage, IEquatable<LobbyJoinCsReq>, IDeepCloneable<LobbyJoinCsReq>, IBufferMessage
	{
		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600747B RID: 29819 RVA: 0x00135B79 File Offset: 0x00133D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyJoinCsReq> Parser
		{
			get
			{
				return LobbyJoinCsReq._parser;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x00135B80 File Offset: 0x00133D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyJoinCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600747D RID: 29821 RVA: 0x00135B92 File Offset: 0x00133D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyJoinCsReq.Descriptor;
			}
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00135B99 File Offset: 0x00133D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinCsReq()
		{
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00135BA4 File Offset: 0x00133DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinCsReq(LobbyJoinCsReq other) : this()
		{
			this.roomId_ = other.roomId_;
			this.dIFNDEGMKNA_ = ((other.dIFNDEGMKNA_ != null) ? other.dIFNDEGMKNA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00135BF0 File Offset: 0x00133DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinCsReq Clone()
		{
			return new LobbyJoinCsReq(this);
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06007481 RID: 29825 RVA: 0x00135BF8 File Offset: 0x00133DF8
		// (set) Token: 0x06007482 RID: 29826 RVA: 0x00135C00 File Offset: 0x00133E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x00135C09 File Offset: 0x00133E09
		// (set) Token: 0x06007484 RID: 29828 RVA: 0x00135C11 File Offset: 0x00133E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP DIFNDEGMKNA
		{
			get
			{
				return this.dIFNDEGMKNA_;
			}
			set
			{
				this.dIFNDEGMKNA_ = value;
			}
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x00135C1A File Offset: 0x00133E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyJoinCsReq);
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00135C28 File Offset: 0x00133E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyJoinCsReq other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && object.Equals(this.DIFNDEGMKNA, other.DIFNDEGMKNA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x00135C78 File Offset: 0x00133E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0UL)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num ^= this.DIFNDEGMKNA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00135CCD File Offset: 0x00133ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00135CD5 File Offset: 0x00133ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00135CE0 File Offset: 0x00133EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dIFNDEGMKNA_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DIFNDEGMKNA);
			}
			if (this.RoomId != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x00135D3C File Offset: 0x00133F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RoomId);
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DIFNDEGMKNA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00135D94 File Offset: 0x00133F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyJoinCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0UL)
			{
				this.RoomId = other.RoomId;
			}
			if (other.dIFNDEGMKNA_ != null)
			{
				if (this.dIFNDEGMKNA_ == null)
				{
					this.DIFNDEGMKNA = new PGDACNIBFMP();
				}
				this.DIFNDEGMKNA.MergeFrom(other.DIFNDEGMKNA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00135DFC File Offset: 0x00133FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00135E08 File Offset: 0x00134008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoomId = input.ReadUInt64();
					}
				}
				else
				{
					if (this.dIFNDEGMKNA_ == null)
					{
						this.DIFNDEGMKNA = new PGDACNIBFMP();
					}
					input.ReadMessage(this.DIFNDEGMKNA);
				}
			}
		}

		// Token: 0x04002CCF RID: 11471
		private static readonly MessageParser<LobbyJoinCsReq> _parser = new MessageParser<LobbyJoinCsReq>(() => new LobbyJoinCsReq());

		// Token: 0x04002CD0 RID: 11472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD1 RID: 11473
		public const int RoomIdFieldNumber = 12;

		// Token: 0x04002CD2 RID: 11474
		private ulong roomId_;

		// Token: 0x04002CD3 RID: 11475
		public const int DIFNDEGMKNAFieldNumber = 7;

		// Token: 0x04002CD4 RID: 11476
		private PGDACNIBFMP dIFNDEGMKNA_;
	}
}
