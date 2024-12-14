using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D1 RID: 4561
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTimedFarmElementCsReq : IMessage<StartTimedFarmElementCsReq>, IMessage, IEquatable<StartTimedFarmElementCsReq>, IDeepCloneable<StartTimedFarmElementCsReq>, IBufferMessage
	{
		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600CBDD RID: 52189 RVA: 0x002234ED File Offset: 0x002216ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTimedFarmElementCsReq> Parser
		{
			get
			{
				return StartTimedFarmElementCsReq._parser;
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600CBDE RID: 52190 RVA: 0x002234F4 File Offset: 0x002216F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTimedFarmElementCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x00223506 File Offset: 0x00221706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTimedFarmElementCsReq.Descriptor;
			}
		}

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x0022350D File Offset: 0x0022170D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementCsReq()
		{
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x00223515 File Offset: 0x00221715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementCsReq(StartTimedFarmElementCsReq other) : this()
		{
			this.worldLevel_ = other.worldLevel_;
			this.pOLKBGLCBJD_ = other.pOLKBGLCBJD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBE2 RID: 52194 RVA: 0x00223546 File Offset: 0x00221746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementCsReq Clone()
		{
			return new StartTimedFarmElementCsReq(this);
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600CBE3 RID: 52195 RVA: 0x0022354E File Offset: 0x0022174E
		// (set) Token: 0x0600CBE4 RID: 52196 RVA: 0x00223556 File Offset: 0x00221756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x0022355F File Offset: 0x0022175F
		// (set) Token: 0x0600CBE6 RID: 52198 RVA: 0x00223567 File Offset: 0x00221767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POLKBGLCBJD
		{
			get
			{
				return this.pOLKBGLCBJD_;
			}
			set
			{
				this.pOLKBGLCBJD_ = value;
			}
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x00223570 File Offset: 0x00221770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTimedFarmElementCsReq);
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x0022357E File Offset: 0x0022177E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTimedFarmElementCsReq other)
		{
			return other != null && (other == this || (this.WorldLevel == other.WorldLevel && this.POLKBGLCBJD == other.POLKBGLCBJD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x002235BC File Offset: 0x002217BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.POLKBGLCBJD != 0U)
			{
				num ^= this.POLKBGLCBJD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x00223614 File Offset: 0x00221814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x0022361C File Offset: 0x0022181C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x00223628 File Offset: 0x00221828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.POLKBGLCBJD != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.POLKBGLCBJD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x00223684 File Offset: 0x00221884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.POLKBGLCBJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POLKBGLCBJD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBEE RID: 52206 RVA: 0x002236DC File Offset: 0x002218DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTimedFarmElementCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.POLKBGLCBJD != 0U)
			{
				this.POLKBGLCBJD = other.POLKBGLCBJD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBEF RID: 52207 RVA: 0x0022372C File Offset: 0x0022192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBF0 RID: 52208 RVA: 0x00223738 File Offset: 0x00221938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.POLKBGLCBJD = input.ReadUInt32();
					}
				}
				else
				{
					this.WorldLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400523F RID: 21055
		private static readonly MessageParser<StartTimedFarmElementCsReq> _parser = new MessageParser<StartTimedFarmElementCsReq>(() => new StartTimedFarmElementCsReq());

		// Token: 0x04005240 RID: 21056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005241 RID: 21057
		public const int WorldLevelFieldNumber = 6;

		// Token: 0x04005242 RID: 21058
		private uint worldLevel_;

		// Token: 0x04005243 RID: 21059
		public const int POLKBGLCBJDFieldNumber = 12;

		// Token: 0x04005244 RID: 21060
		private uint pOLKBGLCBJD_;
	}
}
